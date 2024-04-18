using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankTeller : User
    {
        private string branch; // 지점
        private string position; // 직급

        private static int next_id = 1000000;  // 직원 id 발행용

        public BankTeller(string name, string jumin, string address, 
            string phone, string branch, string position = "사원")
            : base(name, jumin, address, phone)
        {
            this.id = GenId();
            this.branch = branch;
            this.position = position;
        }

        private static int GenId()
        {
            int ret = next_id;
            next_id++;
            return ret;
        }
        public int GetId()
        {
            return this.id;
        }


        public void SetBranch(string branch)
        {
            this.branch = branch;
        }
        public string GetBranch()
        {
            return this.branch;
        }
        public void SetPosition(string position)
        {
            this.position = position;
        }
        public string GetPosition()
        {
            return this.position;
        }


    }

    


}
