using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyCs
{
    internal class CConveyor1 : CDevice
    {
        public CConveyor1()
        {
            carrier = new CCarrier();
        }
            
        // 함수를 재정의 할 때에는 override 키워드를 사용해야함.
        public override void Process()
        {

            if (blsAutoConv == true)
            {
                switch (stepConv)
                {
                    case 0:
                        blsUReq = false;
                        blsLReq = false;
                        blsReady = false;
                        statusCwConv = false;
                        statusCcwConv = false;

                        stepConv = 100;
                        break;
                    case 100:
                        //Load_request는 100번 스텝에서 켜고 120번 스텝으로 넘어가기 전에 끔
                        //Ready는 100번에서 넘어갈 때 켜고 140번 스텝으로 넘어갈 때 끔.
                        //모터는 110번 스텝 넘어가기 전에 켜서 130번 스텝 넘어가기 전에 끔
                        blsLReq = true;
                        if(blsTrReq)
                        {
                            statusCwConv = true;
                            blsReady = true;
                            stepConv = 110;
                        }
                        // 100번 스텝에서는 blsTrReq만 확인해서 110번 스텝으로 이동.
                        break;
                    case 110:
                        if (blsBusy)
                        {
                            
                            stepConv = 120;
                        }
                        //110번 스텝에서는 blsBusy만 확인해서 120번 스텝으로 이동함.
                        break;
                    case 120:
                        if (blsSensorDetect1)
                        {
                            statusCwConv = false;
                            stepConv = 130;
                        }
                        //센서가 감지되면 130번 스텝으로.
                        break;
                    case 130:
                        if(!blsTrReq && !blsBusy && blsCompt)
                        {
                            blsLReq = false;
                            blsReady = false;
                            stepConv = 140;
                        }
                        break;
                    case 140:
                        if(!blsCompt)
                        {
                            stepConv = 200;
                        }
                        break;
                    case 200:
                        if (!blsSensorDetect1 && !blsSensorDetect2)
                        {
                            stepConv = 0;
                        }
                        break;
                    default:
                        stepConv = 0;
                        break;
                }
            }
            else
            {
                stepConv = 0;
            }

            if (oldStepConv != stepConv)
            {
                Console.WriteLine("Conveyor 1 Step = {0}", stepConv);
            }
            oldStepConv = stepConv;
            blsTakeIn = false;
        }
    }
}
