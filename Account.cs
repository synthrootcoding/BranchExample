using System;
using System.Collections.Generic;
using System.Text;

namespace ATMLab
{
    class Account
    {
        private string name;
        private string password;
        private int balance;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account()
        {
            Balance = 0;
        }

        public Account(string name, string password)
        {
            Name = name;
            Password = password;
            Balance = 0;
        }
    }
}
