using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueMarble
{
    public class Bank
    {
        public static Bank thebank = null;

        private int TOTAL_MONEY = 10000; // 만원 단위
        private int money;
        private Player[] players;

        private Bank() // 밖에서는 만들지 마!! 나만 만들꺼임!
        {

        }
        public static void CreatBank() 
        {
            if (thebank != null) // 이중객체 생성금지!
                return;
            thebank = new Bank();
        }

        public void GiveToPlayer(Player p,  int amount)
        {
            money -= amount;
            p.Take(amount);
        }
        public void TakeFromPlayer(Player p, int amount)
        {
            int m = p.Give(amount);
            money += m;
        }

    }
}
