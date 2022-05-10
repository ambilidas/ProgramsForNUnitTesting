using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsForNUnitTesting
{
    internal class BinaryConversion
    {
        public void ToBinary()
        {
            int i;
            int[] a = new int[10];
            Console.WriteLine("\nEnter the number to convert");
            int n=Convert.ToInt32(Console.ReadLine());
            for(i=0; n>0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
                
            }
            Console.WriteLine("Binary of the given number is : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}
