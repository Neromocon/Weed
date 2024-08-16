using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyCs
{
    internal class CConveyorS : CDevice
    {
        public RPIOcs ConvPio1;
        public RPIOcs ConvPio2;
        public RPIOcs ConvPio3;
        public RPIOcs ConvPio4;

        public CConveyorS()
        {
            ConvPio1 = new RPIOcs();
            ConvPio2 = new RPIOcs();
            ConvPio3 = new RPIOcs();
            ConvPio4 = new RPIOcs();

            carrier = new CCarrier();
        }

        public enum SERVO_POS
        {
            CONY_NONE = 0,
            CONY1 = 1,
            CONY2 = 2,
            CONY3 = 3,
            CONY4 = 4
        }
        private SERVO_POS tarPos;
        private SERVO_POS curPos;

        public SERVO_POS TargetPosition
        {
            get { return tarPos; }
        }
        public SERVO_POS CurrentPosition
        {
            get { return curPos; }
            set { curPos = value; }
        }
        private void MovePosition(SERVO_POS target)
        {
            tarPos = target;
        }
        //GetPosition이라는 SERVO_POS을 확인하는 함수를 생성
        public SERVO_POS GetPosition()
        {
            return curPos;
        }
        public override void Process()
        {
            if (blsAutoConv == true)
            {
                switch (stepConv)
                {
                    case 0:
                        //초기화 하는 부분 까먹지 말기!
                        stepConv = 100;
                        break;
                    case 100:
                        if (ConvPio1.UReq) stepConv = 200;
                        else if (ConvPio2.UReq) stepConv = 300;
                        else if (ConvPio3.UReq) stepConv = 400;
                        else if (ConvPio4.UReq) stepConv = 500;                        
                        break;

                    case 200:
                        //서보 모터가 이동하는 부분. 아직 구현화 하지 않아서 멍텅구리 함수를 사용.
                        if(ConvPio1.UReq)
                        {
                            MovePosition(SERVO_POS.CONY1);
                            //Target 1이 들어오면 1번 컨베이어 앞으로 이동하고 2가 들어오면
                            //2번 컨베이어 앞으로 이동할 수 있도록 만들어봄
                            //enum을 사용해 좀 더 직관적으로 볼 수 있게 함
                            if(GetPosition() == SERVO_POS.CONY1)
                            {
                                stepConv = 210;
                            }
                        }
                        break;
                    case 210:
                        //210번 스텝일 경우와 220번 스텝일 경우에는 TR_REQ를 on 해주었음
                        
                        //set / reset방식의 단점이 있음. log로 정확하게 남기지 않으면 어디에서 set을
                        //시켰고, 어디에서 reset을 시키지 않았는지 찾기가 굉장히 어려움.
                        //따라서 log를 잘 남겨야 함.
                        //만약, c언어나 이러한 text기반의 프로그램에서 plc처럼 조건으로 만들거나
                        //interlock을 잘 하려고 한다면 계속 Check하는 방식으로 만들어야 함.
                        //물론, 정말 중요한 interlock은 이렇게 구현을 함. 하지만 모든 것을 이러한
                        //방식으로 만들게 되면 보기도 어렵고 비효율적이라서 추천을 하지 않음.
                        //CW와 CCW가 같이 돌아가면 안되는 정말 중요한 interlock일 경우에는 
                        //C언어에서도 어쩔 수 없이 이러한 방식으로 만들기는 해야 함. 특히 EMO 같은
                        //것을 필요할 때 호출하는 방식으로 만들게 되면 위험해지기 때문임.
                        ConvPio1.TrReq = true;
                        if(ConvPio1.UReq && ConvPio1.Ready)
                        {
                            stepConv = 220;
                        }
                        break;
                    case 220:
                        //220번 스텝일 경우, ccw로 동작을 가동, 230으로 넘어갈 때 ccw를 종료
                        statusCcwConv = true;
                        ConvPio1.Busy = true;
                        if(ConvPio1.Ready && blsSensorDetect1)
                        {
                            statusCcwConv = false;
                            ConvPio1.TrReq = false;
                            ConvPio1.Busy = false;
                            stepConv = 230;
                        }
                        break;
                    case 230:
                        ConvPio1.Compt = true;
                        if(!ConvPio1.Ready)
                        {
                            ConvPio1.Compt = false;
                            stepConv = 240;
                        }
                        break;
                    case 240:
                        stepConv = 600;
                        break;

                    case 300:
                        if (ConvPio2.UReq)
                        {
                            MovePosition(SERVO_POS.CONY2);
                            if (GetPosition() == SERVO_POS.CONY2)
                            {
                                stepConv = 310;
                            }
                        }
                        break;
                    case 310:
                        ConvPio2.TrReq = true;
                        if (ConvPio2.UReq && ConvPio2.Ready)
                        {
                            stepConv = 320;
                        }
                        break;
                    case 320:                        
                        statusCcwConv = true;
                        ConvPio2.Busy = true;
                        if (ConvPio2.Ready && blsSensorDetect2)
                        {
                            statusCcwConv = false;
                            ConvPio2.TrReq = false;
                            ConvPio2.Busy = false;
                            stepConv = 330;
                        }
                        break;
                    case 330:
                        ConvPio2.Compt = true;
                        if (!ConvPio2.Ready)
                        {
                            ConvPio2.Compt = false;
                            stepConv = 240;
                        }
                        break;
                    case 340:
                        stepConv = 600;
                        break;

                    case 400:
                        if (ConvPio3.UReq)
                        {
                            MovePosition(SERVO_POS.CONY3);
                            if (GetPosition() == SERVO_POS.CONY3)
                            {
                                stepConv = 410;
                            }
                        }
                        break;
                    case 410:
                        ConvPio3.TrReq = true;
                        if (ConvPio3.UReq && ConvPio3.Ready)
                        {
                            stepConv = 420;
                        }
                        break;
                    case 420:
                        //3번 컨베이어와 4번 컨베이어의 모터와 센서의 방향은 반대. 따라서 
                        //blsSensorDetect를 변경
                        statusCwConv = true;
                        ConvPio3.Busy = true;
                        if (ConvPio3.Ready && blsSensorDetect2)
                        {
                            statusCwConv = false;
                            ConvPio3.TrReq = false;
                            ConvPio3.Busy = false;
                            stepConv = 430;
                        }
                        break;
                    case 430:
                        ConvPio3.Compt = true;
                        if (!ConvPio3.Ready)
                        {
                            ConvPio3.Compt = false;
                            stepConv = 440;
                        }
                        break;
                    case 440:
                        stepConv = 600;
                        break;

                    case 500:
                        if (ConvPio4.UReq)
                        {
                            MovePosition(SERVO_POS.CONY4);
                            if (GetPosition() == SERVO_POS.CONY4)
                            {
                                stepConv = 510;
                            }
                        }
                        break;
                    case 510:
                        ConvPio4.TrReq = true;
                        if (ConvPio4.UReq && ConvPio4.Ready)
                        {
                            stepConv = 520;
                        }
                        break;
                    case 520:
                        statusCwConv = true;
                        ConvPio4.Busy = true;
                        if (ConvPio4.Ready && blsSensorDetect2)
                        {
                            statusCwConv = false;
                            ConvPio4.TrReq = false;
                            ConvPio4.Busy = false;
                            stepConv = 530;
                        }
                        break;
                    case 530:
                        ConvPio4.Compt = true;
                        if (!ConvPio4.Ready)
                        {
                            ConvPio4.Compt = false;
                            stepConv = 540;
                        }
                        break;
                    case 540:
                        stepConv = 600;
                        break;

                    case 600:
                        if(carrier.id != 0)
                        {
                            if(carrier.use == CCarrier.USE.USE_TAKEOUT)
                                //자제 정보가 take out 이면 1번 컨베이어로 반출
                            {
                                if(ConvPio1.LReq)
                                {
                                    stepConv = 700;
                                    carrier.dest = 1;
                                }
                            }
                            //stack상태이면 3번이나 4번 컨베이어로 적재
                            else if(carrier.use == CCarrier.USE.USE_STACK)
                            {
                                if(ConvPio3.LReq)
                                {
                                    stepConv = 900;
                                    carrier.dest = 3;
                                }
                                if (ConvPio4.LReq)
                                {
                                    stepConv = 1000;
                                    carrier.dest = 4;
                                }
                            }
                            //carrier 정보가 none이면 error로 처리해야하지만 일단 1번 컨베이어로 반출
                            else if(carrier.use == CCarrier.USE.USE_NONE)
                            {
                                //error처리
                                if(ConvPio1.LReq)
                                {
                                    stepConv = 700;
                                    carrier.dest = 1;
                                }
                            }

                        }
                        else
                        {
                            //known id take out
                            //id가 0이면 이상한 것으로 간주 하고 1번 컨베이어로 반출함
                        }
                        
                        break;
                    case 700:
                        if(ConvPio1.LReq)
                        {
                            MovePosition(SERVO_POS.CONY1);
                            if (GetPosition() == SERVO_POS.CONY1)
                                stepConv = 710;
                        }
                        break;
                    case 710:
                        ConvPio1.TrReq = true;
                        if(ConvPio1.LReq && ConvPio1.Ready)
                        {
                            stepConv = 720;
                        }
                        break;
                    case 720:
                        statusCwConv = true;
                        ConvPio1.Busy = true;
                        if(!blsSensorDetect1 && !blsSensorDetect2)
                        {
                            statusCwConv = false;
                            ConvPio1.TrReq = false;
                            ConvPio1.Busy = false;
                            stepConv = 730;
                        }
                        break;
                    case 730:
                        ConvPio1.Compt = true;
                        if(!ConvPio1.Ready)
                        {
                            ConvPio1.Compt = false;
                            stepConv = 100;
                        }
                        break;

                    case 800:
                        if (ConvPio2.LReq)
                        {
                            MovePosition(SERVO_POS.CONY2);
                            if (GetPosition() == SERVO_POS.CONY2)
                                stepConv = 810;
                        }
                        break;
                    case 810:
                        ConvPio2.TrReq = true;
                        if (ConvPio2.LReq && ConvPio2.Ready)
                        {
                            stepConv = 820;
                        }
                        break;
                    case 820:
                        statusCwConv = true;
                        ConvPio2.Busy = true;
                        if (!blsSensorDetect1 && !blsSensorDetect2)
                        {
                            statusCwConv = false;
                            ConvPio2.TrReq = false;
                            ConvPio2.Busy = false;
                            stepConv = 830;
                        }
                        break;
                    case 830:
                        ConvPio2.Compt = true;
                        if (!ConvPio2.Ready)
                        {
                            ConvPio2.Compt = false;
                            stepConv = 100;
                        }
                        break;

                    case 900:
                        if (ConvPio3.LReq)
                        {
                            MovePosition(SERVO_POS.CONY3);
                            if (GetPosition() == SERVO_POS.CONY3)
                                stepConv = 810;
                        }
                        break;
                    case 910:
                        ConvPio3.TrReq = true;
                        if (ConvPio3.LReq && ConvPio3.Ready)
                        {
                            stepConv = 920;
                        }
                        break;
                    case 920:
                        statusCcwConv = true;
                        ConvPio3.Busy = true;
                        if (!blsSensorDetect1 && !blsSensorDetect2)
                        {
                            statusCcwConv = false;
                            ConvPio3.TrReq = false;
                            ConvPio3.Busy = false;
                            stepConv = 930;
                        }
                        break;
                    case 930:
                        ConvPio3.Compt = true;
                        if (!ConvPio3.Ready)
                        {
                            ConvPio3.Compt = false;
                            stepConv = 100;
                        }
                        break;

                    case 1000:
                        if (ConvPio4.LReq)
                        {
                            MovePosition(SERVO_POS.CONY4);
                            if (GetPosition() == SERVO_POS.CONY4)
                                stepConv = 1010;
                        }
                        break;
                    case 1010:
                        ConvPio4.TrReq = true;
                        if (ConvPio4.LReq && ConvPio4.Ready)
                        {
                            stepConv = 1020;
                        }
                        break;
                    case 1020:
                        statusCcwConv = true;
                        ConvPio4.Busy = true;
                        if (!blsSensorDetect1 && !blsSensorDetect2)
                        {
                            statusCcwConv = false;
                            ConvPio4.TrReq = false;
                            ConvPio4.Busy = false;
                            stepConv = 1030;
                        }
                        break;
                    case 1030:
                        ConvPio4.Compt = true;
                        if (!ConvPio4.Ready)
                        {
                            ConvPio4.Compt = false;
                            stepConv = 100;
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
                Console.WriteLine("Shuttle Conveyor  Step = {0}", stepConv);
            }
            oldStepConv = stepConv;
            blsTakeIn = false;
        }
    }
}
