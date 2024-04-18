using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class User
    {
        protected int id;   // 직원 아이디
        private string name; // 이름
        private string jumin; // 주민번호
        private string address; // 주소
        private string phone; // 연락처

        protected User(string name, string jumin, string address, string phone)
        {
            this.id = -1;
            this.name = name;
            this.jumin = jumin;
            this.address = address;
            this.phone = phone;
        }


        public int GetId()
        {
            return this.id;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetJumin()
        {
            return this.jumin;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public string GetAddress()
        {
            return this.address;
        }
        public void SetPhone(string phone)
        {
            this.phone = phone;
        }
        public string GetPhone()
        {
            return this.phone;
        }


    }
}
