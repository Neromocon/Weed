using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueMarble
{
    public class Player : Button
    {
        public int place_id;
        public readonly int player;
        public readonly string name;
        private int money = 0;


        public const int SIZE = 20;
        public const int N_PLAYERS = 4;


        public Player(int player)
        {
            this.player = player;
            Location = new System.Drawing.Point(0, 0);
            Size = new System.Drawing.Size(SIZE, SIZE);
            Text = player.ToString();
        }

        public void MoveXY(int x, int y)
        {
            int half = SIZE / 2;
            Location = new System.Drawing.Point(x - half, y - half);

            BringToFront();
        }

        public int GetMoney()
        {
            return money;
        }

        public int Give(int amount) 
        {
            if(money < amount)
                amount = money;

            money -= amount;
            return amount;
        }

        public void Take(int amount)
        {
            money += amount;
        }
    }
}
