using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    class Program
    {
            public static double AddAndMultiply(double a, double b, double c)
            {
                return (a + b) * c;
            }
            public static void Main()
            {
                Console.WriteLine(AddAndMultiply(3, 6, 35));
                Console.WriteLine(AddAndMultiply(-12, 5,17));
                Console.WriteLine(AddAndMultiply(-40, 50, 60));
                Console.WriteLine(AddAndMultiply(1.7, 9.9, 0.01));
            }
     }  
    
}
