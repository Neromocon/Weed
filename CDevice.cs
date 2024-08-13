using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyCs
{
    abstract class CDevice : IProcess
    //abstract 추상 클래스. 인스턴스화 할 수 없는 클래스. 
    // 이 클래스는 그냥 사용하지 말고 이 클래스를 !상속받아서! 더 구체화 시켜서
    // 사용하라는 의미임.
    {
        protected bool blsTrReq;
        protected bool blsBusy;
        protected bool blsCompt;
        protected bool blsUReq;
        protected bool blsLReq;
        protected bool blsReady;

        public CCarrier carrier;
        // Carrier 정보를 모든 컨베이어에 할당하기 위해 모든 컨베이어의 기본인 CDevice에 상속할 수 
        // 있게 CDevice에에 넣음
        public bool TrReq
        {
            get { return blsTrReq; }
            set { blsTrReq = value; }
        }
        public bool Busy
        {
            get { return blsBusy; }
            set { blsBusy = value; }
        }
        public bool Compt
        {
            get { return blsCompt; }
            set { blsCompt = value; }
        }
        // get, set을 사용함으로서 protected로  선언된
        // 변수를 외부에서도 접근할 수 있게 문을 열어주게 됨.
        public bool UReq
        {
            get { return blsUReq; }
        }
        public bool LReq
        {
            get { return blsLReq; }
        }
        public bool Ready
        {
            get { return blsReady; }
        }
        // 나머지 3개의 변수인 blsUReq, blsLReq, blsReady를 다르게 한 이유는
        // 자기 자신만 바꾸게 할 수 있게 만들기 위함임. 즉 외부에서 접근을 아예
        // 못하게 하기 위함.

        protected bool statusCwConv;
        protected bool statusCcwConv;
        public bool statusCw
        {
            get { return statusCwConv; }
            set {  statusCwConv = value; }
        }
        public bool statusCcw
        {
            get { return statusCcwConv; }
            set { statusCcwConv = value; }
        }

        protected int stepConv;
        protected int oldStepConv;
        protected int countConv;
        public int step
        {
            get { return stepConv; }
            set { stepConv = value; }
        }
        public int oldStep
        {
            get { return oldStepConv; }
            set { oldStepConv = value; }
        }
        public int count
        {
            get { return countConv; }
            set { countConv = value; }
        }

        protected bool blsAutoConv;
        protected bool blsTakeIn, blsTakeOut;
        public bool auto
        {
            get { return blsAutoConv; }
            set { blsAutoConv = value; }
        }
        public bool takeIn
        {
            get { return blsTakeIn; }
            set { blsTakeIn = value; }
        }
        public bool takeOut
        {
            get { return blsTakeOut; }
            set { blsTakeOut = value; }
        }

        // 구현하지 않으면 에러가 발생, 따라서 추상 함수를 사용.
        //추상함수 > 구현없이 뼈대만 만들 수 있는 함수. 추상클래스와 비슷한 내용.
        public abstract void Process();

        protected bool blsSensorDetect1, blsSensorDetect2;
        public bool sensor1
        {
            get { return blsSensorDetect1; }
            set { blsSensorDetect1 = value; }
        }
        public bool sensor2
        {
            get { return blsSensorDetect2; }
            set { blsSensorDetect2 = value; }
        }

    }
}
