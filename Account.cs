using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Account
    {
        public enum eWithdrawCode{OK, LowBalance, Password, Number}

        private int number;             // 계좌 번호
        private int client_id;          // 고객 id
        private int balance;            // 은행 잔고
        private int password;           // 비밀 번호
        private double interest_rate;   // 이율


        private static int next_number = 1110000000;  // 계좌번호

        public Account(int client_id, int password, double interest_rate = 1.0)
        {
            this.number = GenNumber();
            this.client_id = client_id;
            this.balance = 0;
            this.password = password % 10000;
            this.interest_rate = interest_rate;
        }

        public int GetNumber() 
        {
            return number;
        }
        public int GetClientId()
        {
            return client_id;
        }
        public int GetBalance(int password)
        {
            if(password != this.password)
                return -1;
            return balance;
        }
        public double GetInterestRate()
        {
            return interest_rate;
        }

        public void deposit(int m) 
        {
            balance += m;
        }
        public eWithdrawCode withdraw(int m, int password)
        {
            if(this.password != password) 
            
                return eWithdrawCode.Password;
            
            if(this.balance < m) 
            
                return eWithdrawCode.LowBalance;

            // 핵심 코드 입출금
            this.balance -= m;

            return eWithdrawCode.OK;
        }







        private static int GenNumber()
        {
            int ret = next_number;
            next_number++;
            return ret;
        }



    }
}
