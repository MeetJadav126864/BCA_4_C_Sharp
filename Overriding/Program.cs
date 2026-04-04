using System;

namespace prog22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Savings s = new Savings();
            s.getAccount();  
            s.display();     

            Account a = new Account();
            a.getAccount();  
            a.display();     


        }
    }
}