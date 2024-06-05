using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueMarbleEx2
{
    public class Bank
    {
        private int TOTAL_MONEY = 10000;
        private int money;
        private Player[] players;
        public void GiveToPlayer(Player p, int amount)
        {
            money -= amount;
            p.Take(amount);
        }
        public void TakeFromPlayer(Player p, int amount)
        {
            int m = p.Give(amount);
            money += m;
        }
    }//3.43:10
}
