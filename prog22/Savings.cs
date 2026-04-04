using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog22
{
    internal class Savings:Account
    {
        int interest_rate;

        public void get_data()
        {
            Console.WriteLine("Enter Interest Rate: ");
            interest_rate = Convert.ToInt32(Console.ReadLine());
        }

        public void show()
        {
            Console.WriteLine("Interest Rate: " + interest_rate);
        }


    }
}
