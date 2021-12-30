using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop lp = new Laptop();

            lp.ShowDetails(Laptop.Lenovo, Laptop.Price1000, Laptop.i3, Laptop.Ram2GB, Laptop.HD500GB);

        }
    }
}
