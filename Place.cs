using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BlueMarble
{
    public class Place : Button // Ctrl + . --> using System.Windows.Forms; 생성
    // public으로 전환
    {
        enum ePosition { bottom, left, top, right, edge }

        private ePosition pos;

        const int LONG_SIDE = 100;
        const int SHORT_SIDE = 50;

        const int TOTAL_SIDE = LONG_SIDE * 2 + SHORT_SIDE * 9;
        public const int N_PLACES = 40;

        public readonly int x, y; // 위치
        public readonly int w, h; // 길이?
        public readonly int center_x, center_y;

        public readonly string name;
        public readonly string eng_name;
        public readonly int price;
        public readonly int pay;
        public readonly bool can_buy; // 구매 가능 여부

        public Place(int id, string name = "", string eng_name = "", int price = 0, int pay = 0, bool can_buy = true)
        {
            this.name = name;
            this.eng_name = eng_name;
            this.price = price;
            this.pay = pay;
            this.can_buy = can_buy;

            if (price != 0)
            {
                Text = $"{name}\n{price}만원";
            }
            else 
            {
                Text = name;
            }

            // id 별로 위치 정하기 --> 그리기 할 때, 표시가 될 것임! :)
            if (id % 10 == 0)
                pos = ePosition.edge;
            else 
                pos = (ePosition)(id / 10);


            w = h = LONG_SIDE;

            switch(pos)
            {
                case ePosition.bottom:
                    w = SHORT_SIDE;
                    y = TOTAL_SIDE - LONG_SIDE;
                    x = TOTAL_SIDE - LONG_SIDE - SHORT_SIDE * (id % 10);
                    break;
                case ePosition.top:
                    w = SHORT_SIDE;
                    y = 0;
                    x = 0 + LONG_SIDE + SHORT_SIDE * (id % 10 -1); 
                    break;
                case ePosition.left:
                    h = SHORT_SIDE;
                    x = 0;
                    y = TOTAL_SIDE - LONG_SIDE - SHORT_SIDE * (id % 10);
                    break;
                case ePosition.right:
                    h = SHORT_SIDE;
                    x = TOTAL_SIDE - LONG_SIDE;
                    y = 0 + LONG_SIDE + SHORT_SIDE * (id % 10 - 1);
                    break;
                case ePosition.edge:
                    x = (id == 10 || id == 20) ? 0 : TOTAL_SIDE - LONG_SIDE;
                    y = (id == 20 || id == 30) ? 0 : TOTAL_SIDE - LONG_SIDE;
                    break;
            }
            // 중심 부분
            center_x = x + w / 2;
            center_y = y + h / 2;

            this.Size = new System.Drawing.Size(w, h);
            this.Location = new System.Drawing.Point(x, y);

            // 출발 타이베이 황금열쇠 베이징 마닐라 제주 싱가포르 황금열쇠 카이로 이스탄불 무인도
            // 아테네 황금열쇠 코펜하겐 스톡홀름 콩코드여객기 베른 황금열쇠 베를린 오타와 사회복지기금
            // 부에노스아이레스 황금열쇠 상파울로 시드니 부산 하와이 리스본 퀸엘리자베스호 마드리드 우주여행
            // 도쿄 컬럼버스호 파리 로마 황금열쇠 런던 뉴욕 사회복지기금 서울

            // 출 5 / 8 8 20 10 / 10 12 무
            // 14 / 16 16 18 / 18 20 사회
            // 22 / 24 50 26 26 30 28 우주
            // 30 45 32 32 / 35 35 15 100 출
        }
    }
}
