using System;

namespace prog22
{
    internal class Savings : Account
    {
        int interest_rate;

        public override void getAccount()
        {
            //base.getAccount(); 
            Console.WriteLine("Enter Interest Rate: ");
            interest_rate = Convert.ToInt32(Console.ReadLine());
        }

        public override void display()
        {
            base.display(); 
            Console.WriteLine("Interest Rate: " + interest_rate);
        }
    }
}