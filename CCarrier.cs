using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyCs
{
    internal class CCarrier
    {
        public UInt64 id; //자제 구분을 위한 ID
        public UInt16 source; 
        public UInt16 dest;
        //출발지점과 목적지를 구분하기 위해 source, dest를 만듬
        public USE use;

        public enum USE
        {
            USE_NONE,
            USE_TAKEOUT,
            USE_STACK
            // 저장을 할 것인지 반출할 것인지를 구분하기 위한 enum USE 변수
        }

        public void Clear()//초기화 함수
        {
            id = 0;
            source = 0;
            dest = 0;
            use = USE.USE_NONE;
        }
    }
}
