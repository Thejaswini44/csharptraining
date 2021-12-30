using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemparatureProgram
{
    class Program
    {
         public static string CtoF(double celsius)
        {
            double fahrenheit;
            if(celsius < -273.15)
            {
                return "Temperature below absolute zero";

            }
            fahrenheit = celsius * 1.8 + 32;
            return $"T {fahrenheit}F";

        }
        public static void Main()
        {
            Console.WriteLine(CtoF(0));
            Console.WriteLine(CtoF(-300));
            Console.WriteLine(CtoF(28.5));
        }
    }
}
