using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        public static List<int> test(List<int> nums)
        {
            IEnumerable<int> e = nums.Select(x => 5 * (x + 2));
            return e.ToList();
        }
    }

}
 
