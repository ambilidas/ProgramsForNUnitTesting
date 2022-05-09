using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsForNUnitTesting
{
    internal class TempConversion
    {
        public void temperatureConversion()
        {
            int select;
            //user selection
            Console.WriteLine("Enter 0 : Celsius to Fahrenheit");
            Console.WriteLine("Enter 1 : Fahrenheit to Celsius");
            select =Convert.ToInt32(Console.ReadLine());
            if(select == 0)
            {
                Console.WriteLine("Enter temperature in Celsius");
                float C=Convert.ToInt32(Console.ReadLine());
                float F = (float)(C * 9 / 5) + 32;
                Console.WriteLine(F+" degree Fahrenheit");

            }
            else if(select == 1)
            {
                Console.WriteLine("Enter temperature in Fahrenheit");
                float F = Convert.ToInt32(Console.ReadLine());
                float C = (float)(F-32)*5/9;
                Console.WriteLine(C+" degree Celsius");
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }
        }
    }
}
