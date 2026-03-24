using System;

namespace prog21
{
    internal class car:Vehicle
    {
        string model_type, company_name;

        public void get_car()
        {
            Console.WriteLine("Enter model type");
            model_type = Console.ReadLine();
            Console.WriteLine("Enter company name");
            company_name = Console.ReadLine();
        }

        public void show_car()
        {
            Console.WriteLine("Model type is: " + model_type);
            Console.WriteLine("Company name is: " + company_name);
        }


    }
}
