using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank.Account;

namespace Bank
{
    internal class Bank
    {
        string name;
        List<BankTeller> Tellers = new List<BankTeller>();
        List<Client> Clients = new List<Client>();
        List<Account> Accounts = new List<Account>();

        public Bank(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name}: 직원({Tellers.Count}), 고객({Clients.Count}), 계좌({Accounts.Count})";
        }

        public Client CreateClient(string name, string jumin, string address, string phone)
        {
            Client cli = findClient(jumin);
            if (cli != null) // 기존에 존재하는 경우
            {
                cli.SetPhone(phone);
                cli.SetAddress(address);
                return cli;
            }

            cli = new Client(name, jumin, address, phone);
            Clients.Add(cli);
            return cli;
        }

        public int CreateAccount(string jumin, int password)
        {
            Client cli = findClient(jumin);
            if (cli == null)
                return -1;

            Account acc = new Account(cli.GetId(), password);
            Accounts.Add(acc);
            return acc.GetNumber();
        }





        public Client findClient(string jumin)
        {
            foreach (Client client in Clients)
            {
                if (client.GetJumin() == jumin)
                    return client;
            }

            return null;  // 못찾음
        }
        public BankTeller findTeller(int id)
        {
            foreach (BankTeller t in Tellers)
            {
                if (t.GetId() == id)
                    return t;
            }

            return null;  // 못찾음
        }

        private Account findAccount(int number)
        {
            foreach (Account a in Accounts)
            {
                if (a.GetNumber() == number)
                    return a;
            }

            return null;  // 못찾음
        }

        public bool deposit(int number, int m)
        {
            Account acc = findAccount(number);
            if (acc == null)
                return false;

            acc.deposit(m);

            return true;
        }
        public eWithdrawCode withdraw(int number,int password, int m)
        {
            Account acc = findAccount(number);
            if (acc == null)
                return eWithdrawCode.Number;



            return acc.withdraw(m, password); 
        }

        //int m,
        public eWithdrawCode GetBalance(int number, int password, out int balance)
        {
            balance = 0;

            Account acc = findAccount(number);
            if (acc == null)
                return eWithdrawCode.Number;

            int b = acc.GetBalance(password);
            if (b<0)
                return eWithdrawCode.Password;

            balance = b;

            return eWithdrawCode.OK;
        }

        public eWithdrawCode tranfer(int my_number, int password, int m, int your_number)
        {
            Account acc = findAccount(my_number);
            if (acc == null)
                return eWithdrawCode.Number;

            Account acc2 = findAccount(your_number);
            if (acc2 == null)
                return eWithdrawCode.Number;

            eWithdrawCode c = acc.withdraw(m, password);

            if (c != eWithdrawCode.OK)
                return c;

            acc2.deposit(m);

            return eWithdrawCode.OK;
        }

    }
}
