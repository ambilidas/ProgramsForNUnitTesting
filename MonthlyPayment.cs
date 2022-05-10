using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsForNUnitTesting
{
    internal class MonthlyPayment
    {
        public void monthlyPaymentCalc()
        {
            Console.WriteLine("Enter the principal loan amount: ");
            int P=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year: ");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest: ");
            int R = Convert.ToInt32(Console.ReadLine());

            //calculations
            int n = 12 * Y;
            float r = (float)R / (12 * 100);
            double x = Math.Pow(1 + r, -n);
            double y = 1 - x;
            double payment = (P * r) / y;

            //printing result
            Console.WriteLine("Payment = Rs."+payment);


        }
    }
}
