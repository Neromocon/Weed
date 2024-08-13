using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConveyCs
{
    public partial class Form1 : Form
    {
        CConveyor1 conveyor1;
        CConveyor2 conveyor2;
        CConveyor3 conveyor3;
        CConveyor4 conveyor4;
        CConveyorS conveyorS;
        public Form1()
        {
            InitializeComponent();
            conveyor1 = new CConveyor1();
            conveyor2 = new CConveyor2();
            conveyor3 = new CConveyor3();
            conveyor4 = new CConveyor4();
            conveyorS = new CConveyorS();
        }

        //struct PIO
        //{
        //    public bool blsTrReq;
        //    public bool blsBusy;
        //    public bool blsCompt;
        //    public bool blsUReq;
        //    public bool blsLReq;
        //    public bool blsReady;
        //}
        //PIO pioConv1, pioConv2, pioConv3, pioConv4;

        // Motor의 상태를 저장할 변수를 생성.
        //bool statusCwConv1, statusCwConv2, statusCwConv3, statusCwConv4, statusCwConvS;
        //bool statusCcwConv1, statusCcwConv2, statusCcwConv3, statusCcwConv4, statusCcwConvS;

        private void btnTakeIn_Click(object sender, EventArgs e)
        {
            if(conveyor2.carrier.id == 0)
            {
                conveyor2.carrier.id = 1;
                conveyor2.carrier.source = 2;
                conveyor2.carrier.use = CCarrier.USE.USE_STACK;
                //저장을 하게 될 자재에 대한 정보를 넣음.
                conveyor2.takeIn = true;
                //blsTakeIn = true;

                Console.WriteLine("Input Button Clicked..!");
            }


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            conveyor1.auto = false;
            conveyor2.auto = false;
            conveyor3.auto = false;
            conveyor4.auto = false;
            conveyorS.auto = false;
            //blsAutoConv1 = false;
            //blsAutoConv2 = false;
            //blsAutoConv3 = false;
            //blsAutoConv4 = false;
            //blsAutoConvS = false;
        }

        private void btnTakeOut_Click(object sender, EventArgs e)
        {

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            conveyor1.auto = true;
            conveyor2.auto = true;
            conveyor3.auto = true;
            conveyor4.auto = true;
            conveyorS.auto = true;
        }

        bool ConvMotionBlink;
        private void ConvMotionProc_Tick(object sender, EventArgs e)
        {
            if(ConvMotionBlink == true)
            {
                btnConveyor1.Text = "";
                btnConveyor2.Text = "";
                btnConveyor3.Text = "";
                btnConveyor4.Text = "";
                btnConveyorS.Text = "";
                ConvMotionBlink = false;
            }
            else
            {
                if (!conveyor1.statusCw && !conveyor1.statusCcw) btnConveyor1.Text = "";
                else if (conveyor1.statusCw) btnConveyor1.Text = "CW";
                else if (conveyor1.statusCcw) btnConveyor1.Text = "CCW";

                if (!conveyor2.statusCw && conveyor2.statusCcw) btnConveyor2.Text = "";
                else if (conveyor2.statusCw) btnConveyor2.Text = "CW";
                else if (conveyor2.statusCcw) btnConveyor2.Text = "CCW";

                if (!conveyor3.statusCw && conveyor3.statusCcw) btnConveyor3.Text = "";
                else if (conveyor3.statusCw) btnConveyor3.Text = "CW";
                else if (conveyor3.statusCcw) btnConveyor3.Text = "CCW";

                if (!conveyor4.statusCw && conveyor4.statusCcw) btnConveyor4.Text = "";
                else if (conveyor4.statusCw) btnConveyor4.Text = "CW";
                else if (conveyor4.statusCcw) btnConveyor4.Text = "CCW";

                if (!conveyorS.statusCw && conveyorS.statusCcw) btnConveyorS.Text = "";
                else if (conveyorS.statusCw) btnConveyorS.Text = "CW";
                else if (conveyorS.statusCcw) btnConveyorS.Text = "CCW";

                ConvMotionBlink = true;
            }
        }

        //Step에 사용할 변수를 생성.
        //int stepConv1, stepConv2, stepConv3, stepConv4, stepConvS;
        //int oldStepConv1, oldStepConv2, oldStepConv3, oldStepConv4, oldStepConvS;
        //int countConv1, countConv2, countConv3, countConv4, countConvS;

        //bool blsAutoConv1, blsAutoConv2, blsAutoConv3, blsAutoConv4, blsAutoConvS;
        //bool blsTakeIn, blsTakeOut;
        private void MainSchedulerProc_Tick(object sender, EventArgs e)
        {
            //ProcConv1();
            //ProcConv2();
            //ProcConv3();
            //ProcConv4();
            //ProcConvS();
            conveyor1.Process();
            conveyor2.Process();
            conveyor3.Process();
            conveyor4.Process();
            conveyorS.Process();
            
            PioExchanger();
            DataExchanger();
            MotionContols();
            //MotionContols()함수를 호출해서 서보를 목적지에 따라 위치를 이동시킴
        }
        private void DataExchanger()
        {
            if(conveyor1.Compt)
            {
                if(conveyor1.LReq)
                {
                    if(conveyorS.carrier.id != 0)
                    {
                        conveyor1.carrier.id = conveyorS.carrier.id;
                        conveyor1.carrier.source = conveyorS.carrier.source;
                        conveyor1.carrier.dest = conveyorS.carrier.dest;
                        conveyor1.carrier.use = conveyorS.carrier.use;
                        conveyorS.carrier.Clear();
                        //Compt신호가 들어왔을 때, LoadRequest, Unlocad Request 신호로 구분을 해서
                        //데이터를 옮겨 주도록 진행

                        Console.WriteLine("Carrier Data Move : S -> 1");
                    }
                }
                if (conveyor1.UReq)
                {
                    if (conveyor1.carrier.id != 0)
                    {
                        conveyorS.carrier.id = conveyor1.carrier.id;
                        conveyorS.carrier.source = conveyor1.carrier.source;
                        conveyorS.carrier.dest = conveyor1.carrier.dest;
                        conveyorS.carrier.use = conveyor1.carrier.use;
                        conveyor1.carrier.Clear();

                        Console.WriteLine("Carrier Data Move : 1 -> S");
                    }
                }
            }
            if (conveyor2.Compt)
            {
                if (conveyor2.LReq)
                {
                    if (conveyorS.carrier.id != 0)
                    {
                        conveyor2.carrier.id = conveyorS.carrier.id;
                        conveyor2.carrier.source = conveyorS.carrier.source;
                        conveyor2.carrier.dest = conveyorS.carrier.dest;
                        conveyor2.carrier.use = conveyorS.carrier.use;
                        conveyorS.carrier.Clear();

                        Console.WriteLine("Carrier Data Move : S -> 2");
                    }
                }
                if (conveyor2.UReq)
                {
                    if (conveyor2.carrier.id != 0)
                    {
                        conveyorS.carrier.id = conveyor2.carrier.id;
                        conveyorS.carrier.source = conveyor2.carrier.source;
                        conveyorS.carrier.dest = conveyor2.carrier.dest;
                        conveyorS.carrier.use = conveyor2.carrier.use;
                        conveyor2.carrier.Clear();

                        Console.WriteLine("Carrier Data Move : 2 -> S");
                    }
                }
            }
            if (conveyor3.Compt)
            {
                if (conveyor3.LReq)
                {
                    if (conveyorS.carrier.id != 0)
                    {
                        conveyor3.carrier.id = conveyorS.carrier.id;
                        conveyor3.carrier.source = conveyorS.carrier.source;
                        conveyor3.carrier.dest = conveyorS.carrier.dest;
                        conveyor3.carrier.use = conveyorS.carrier.use;
                        conveyorS.carrier.Clear();

                        Console.WriteLine("Carrier Data Move : S -> 3");
                    }
                }
                if (conveyor3.UReq)
                {
                    if (conveyor3.carrier.id != 0)
                    {
                        conveyorS.carrier.id = conveyor3.carrier.id;
                        conveyorS.carrier.source = conveyor3.carrier.source;
                        conveyorS.carrier.dest = conveyor3.carrier.dest;
                        conveyorS.carrier.use = conveyor3.carrier.use;
                        conveyor3.carrier.Clear();

                        Console.WriteLine("Carrier Data Move : 3 -> S");
                    }
                }
            }
            if (conveyor4.Compt)
            {
                if (conveyor4.LReq)
                {
                    if (conveyorS.carrier.id != 0)
                    {
                        conveyor4.carrier.id = conveyorS.carrier.id;
                        conveyor4.carrier.source = conveyorS.carrier.source;
                        conveyor4.carrier.dest = conveyorS.carrier.dest;
                        conveyor4.carrier.use = conveyorS.carrier.use;
                        conveyorS.carrier.Clear();

                        Console.WriteLine("Carrier Data Move : S -> 4");
                    }
                }
                if (conveyor4.UReq)
                {
                    if (conveyor4.carrier.id != 0)
                    {
                        conveyorS.carrier.id = conveyor4.carrier.id;
                        conveyorS.carrier.source = conveyor4.carrier.source;
                        conveyorS.carrier.dest = conveyor4.carrier.dest;
                        conveyorS.carrier.use = conveyor4.carrier.use;
                        conveyor4.carrier.Clear();

                        Console.WriteLine("Carrier Data Move : 4 -> S");
                    }
                }
            }

        }


        private void MotionContols()
        {
            
            switch(conveyorS.TargetPosition)
            {
                case CConveyorS.SERVO_POS.CONY_NONE:
                    btnConveyorS.Location = new System.Drawing.Point(230, 160);
                    cbSensorS_1.Location = new System.Drawing.Point(170, 160);
                    cbSensorS_2.Location = new System.Drawing.Point(170, 240);
                    break;
                case CConveyorS.SERVO_POS.CONY1:
                    btnConveyorS.Location = new System.Drawing.Point(100, 160);
                    cbSensorS_1.Location = new System.Drawing.Point(40, 160);
                    cbSensorS_2.Location = new System.Drawing.Point(40, 240);
                    break;
                case CConveyorS.SERVO_POS.CONY2:
                    btnConveyorS.Location = new System.Drawing.Point(360, 160);
                    cbSensorS_1.Location = new System.Drawing.Point(300, 160);
                    cbSensorS_2.Location = new System.Drawing.Point(300, 240);
                    break;
                case CConveyorS.SERVO_POS.CONY3:
                    btnConveyorS.Location = new System.Drawing.Point(100, 160);
                    cbSensorS_1.Location = new System.Drawing.Point(40, 160);
                    cbSensorS_2.Location = new System.Drawing.Point(40, 240);
                    break;
                case CConveyorS.SERVO_POS.CONY4:
                    btnConveyorS.Location = new System.Drawing.Point(360, 160);
                    cbSensorS_1.Location = new System.Drawing.Point(300, 160);
                    cbSensorS_2.Location = new System.Drawing.Point(300, 240);
                    break;
                default:
                    btnConveyorS.Location = new System.Drawing.Point(230, 160);
                    cbSensorS_1.Location = new System.Drawing.Point(170, 160);
                    cbSensorS_2.Location = new System.Drawing.Point(170, 240);
                    break;
            }
            conveyorS.CurrentPosition = conveyorS.TargetPosition;
        }
        private void PioExchanger()
        {
            conveyor1.TrReq = conveyorS.ConvPio1.TrReq;
            conveyor1.Busy = conveyorS.ConvPio1.Busy;
            conveyor1.Compt = conveyorS.ConvPio1.Compt;
            conveyorS.ConvPio1.LReq = conveyor1.LReq;
            conveyorS.ConvPio1.UReq = conveyor1.UReq;
            conveyorS.ConvPio1.Ready = conveyor1.Ready;

            conveyor2.TrReq = conveyorS.ConvPio2.TrReq;
            conveyor2.Busy = conveyorS.ConvPio2.Busy;
            conveyor2.Compt = conveyorS.ConvPio2.Compt;
            conveyorS.ConvPio2.LReq = conveyor2.LReq;
            conveyorS.ConvPio2.UReq = conveyor2.UReq;
            conveyorS.ConvPio2.Ready = conveyor2.Ready;

            conveyor3.TrReq = conveyorS.ConvPio3.TrReq;
            conveyor3.Busy = conveyorS.ConvPio3.Busy;
            conveyor3.Compt = conveyorS.ConvPio3.Compt;
            conveyorS.ConvPio3.LReq = conveyor3.LReq;
            conveyorS.ConvPio3.UReq = conveyor3.UReq;
            conveyorS.ConvPio3.Ready = conveyor3.Ready;

            conveyor4.TrReq = conveyorS.ConvPio4.TrReq;
            conveyor4.Busy = conveyorS.ConvPio4.Busy;
            conveyor4.Compt = conveyorS.ConvPio4.Compt;
            conveyorS.ConvPio4.LReq = conveyor4.LReq;
            conveyorS.ConvPio4.UReq = conveyor4.UReq;
            conveyorS.ConvPio4.Ready = conveyor4.Ready;
        }

        private void cbSensor1_1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSensor1_1.Checked)
                conveyor1.sensor1 = true;
            else
                conveyor1.sensor1 = false;
        }
        private void cbSensor1_2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor1_2.Checked)
                conveyor1.sensor2 = true;
            else
                conveyor1.sensor2 = false;
        }
        private void cbSensor2_1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor2_1.Checked)
                conveyor2.sensor1 = true;
            else
                conveyor2.sensor1 = false;
        }
        private void cbSensor2_2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor2_2.Checked)
                conveyor2.sensor2 = true;
            else
                conveyor2.sensor2 = false;
        }
        private void cbSensor3_1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor3_1.Checked)
                conveyor3.sensor1 = true;
            else
                conveyor3.sensor1 = false;
        }
        private void cbSensor3_2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor3_2.Checked)
                conveyor3.sensor2 = true;
            else
                conveyor3.sensor2 = false;
        }
        private void cbSensor4_1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor4_1.Checked)
                conveyor4.sensor1 = true;
            else
                conveyor4.sensor1 = false;
        }
        private void cbSensor4_2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensor4_2.Checked)
                conveyor4.sensor2 = true;
            else
                conveyor4.sensor2 = false;
        }
        private void cbSensorS_1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensorS_1.Checked)
                conveyorS.sensor1 = true;
            else
                conveyorS.sensor1 = false;
        }
        private void cbSensorS_2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSensorS_2.Checked)
                conveyorS.sensor2 = true;
            else
                conveyorS.sensor2 = false;
        }

        //void ProcConv1()
        //{

        //}
        //void ProcConv2()
        //{
        //    if(blsAutoConv2 == true)
        //    {
        //        switch(stepConv2)
        //        {
        //            case 0:
        //                pioConv1.blsUReq = false;
        //                pioConv1.blsLReq = false;
        //                pioConv1.blsReady = false;
        //                statusCwConv2 = false;
        //                statusCcwConv2 = false;

        //                stepConv2 = 100;
        //                break;
        //            case 100:
        //                if(cbSensor2_2.Checked == true)
        //                {
        //                    stepConv2 = 200;
        //                }
        //                else
        //                {
        //                    if(blsTakeIn == true)
        //                    {
        //                        stepConv2 = 110;
        //                        countConv2 = 0;
        //                    }
        //                }
        //                break;
        //            case 110:
        //                statusCcwConv2 = true;
        //                if(cbSensor2_2.Checked == true)
        //                {
        //                    statusCcwConv2 = false;
        //                    pioConv2.blsUReq = true;
        //                    stepConv2 = 200;
        //                }
        //                break;
        //            case 200:
        //                if(cbSensor2_2.Checked == false)
        //                {
        //                    stepConv2 = 100;
        //                }
        //                else if (pioConv2.blsTrReq)
        //                {
        //                    stepConv2 = 210;
        //                    pioConv2.blsReady = true;
        //                }
        //                break;
        //            case 210:
        //                if (pioConv2.blsBusy)
        //                {
        //                    pioConv2.blsUReq = true;
        //                    stepConv2 = 220;
        //                }
        //                break;
        //            case 220:
        //                statusCcwConv2 = true;
        //                if (!pioConv2.blsTrReq && !pioConv2.blsBusy && pioConv2.blsCompt)
        //                {
        //                    pioConv2.blsUReq = false;
        //                    statusCcwConv2 = false;
        //                    stepConv2 = 230;
        //                }
        //                break;
        //            case 230:
        //                if (!pioConv2.blsCompt)
        //                    stepConv2 = 100;
        //                break;
        //            default:
        //                stepConv2 = 0;
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        stepConv2 = 0;
        //    }

        //    if (oldStepConv2 != stepConv2)
        //    {
        //        Console.WriteLine("Conveyor 2 Step = {0}", stepConv2);
        //    }
        //    oldStepConv2 = stepConv2;
        //    blsTakeIn = false;
        //}
        //void ProcConv3()
        //{

        //}
        //void ProcConv4()
        //{

        //}
        //void ProcConvS()
        //{

        //}
    }
}
