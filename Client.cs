using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Client : User
    {

        private int grade; // 신용등급

        private static int next_id = 100000000;  // 고객 id 발행용
        public Client(string name, string jumin, string address, string phone, int grade = 5)
            :base(name, jumin, address, phone)
        {
            this.id = GenId();
            this.grade = grade;
        }

        private static int GenId()
        {
            int ret = next_id;
            next_id++;
            return ret;
        }


    }
}
