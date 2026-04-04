using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog22
{
    internal class Account
    {
        int accountNo, balance;

        public void getAccount()
        {
            Console.WriteLine("Enter Account no: ");
            accountNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Balance: ");
            balance = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Account No: " + accountNo);
            Console.WriteLine("Balance: " + balance);
        }

    }
}
