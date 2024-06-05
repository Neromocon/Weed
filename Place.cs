using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BlueMarbleEx2
{
    public class Place : Button
    {
        enum ePosition { bottom, left, top, right, edge }

        private ePosition pos;

        const int LONG_SIDE = 100;
        const int SHORT_SIDE = 50;

        const int TOTAL_SIDE = LONG_SIDE * 2 + SHORT_SIDE * 9;
        public const int N_PLACES = 40;

        public readonly int w, h;
        public readonly int x, y;
        public readonly int center_x, center_y;

        public readonly string name;
        public readonly string eng_name;
        public readonly int price;
        public readonly bool can_buy;

        public Place(int id, string name = "", string eng_name = "", int price = 0, bool can_buy = true)
        {
            this.name = name;
            this.eng_name = eng_name;
            this.price = price;
            this.can_buy = can_buy;

            if(price != 0)
            {
                Text = $"{name}\n{price}";
            }
            else
            {
                Text = name;
            }

            if (id % 10 == 0)
                pos = ePosition.edge;
            else 
                pos = (ePosition)(id / 10);

            w = h = LONG_SIDE;

            switch (pos)
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
            center_x = x + w / 2;
            center_y = y + h / 2;

            this.Size = new System.Drawing.Size(w, h);
            this.Location = new System.Drawing.Point(x, y);
        }
    }
}
