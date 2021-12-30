using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueObjectsExample
{
    class Program
    {
        static void Main(string[] args)

        {
            Queue queue = new Queue();
            int total = 3;

            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                queue.Enqueue(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            for (int i = 0; i < total; i++)
            {
                Person p = (Person)queue.Dequeue();
                Console.WriteLine(p.ToString());
            }
        }

        public class Person
        {
            public string Name;
            public int Age;


            public override string ToString()
            {
                return Name + " - " + Age;
            }
        }
    }
}
