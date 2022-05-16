using System;

namespace ProgramsForNUnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Programs for NUnit Testing");
            bool choice=true;
            while (choice)
            {
                Console.WriteLine("\nEnter the question number for running program");
                Console.WriteLine("\nQ1:Day of Week Problem");
                Console.WriteLine("Q2:Temperature Conversion program");
                Console.WriteLine("Q3:Monthly payment calculation program");
                Console.WriteLine("Q4:Vending Machine program");
                int select=Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        DayOfWeek obj1 = new DayOfWeek();
                        obj1.dayOfWeek();
                        break;
                    case 2:
                        TempConversion obj2 = new TempConversion();
                        obj2.temperatureConversion();
                        break;
                    case 3:
                        MonthlyPayment obj3 = new MonthlyPayment();
                        obj3.monthlyPaymentCalc();
                        break;
                    case 4:
                        VendingMachine obj4 = new VendingMachine();
                        obj4.Driver();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }

            }
            
            
            
           // SquareRoot obj5 = new SquareRoot();
            //obj5.sqrt();
            //BinaryConversion obj6 = new BinaryConversion();
            //obj6.ToBinary();
            

        }
    }
}
