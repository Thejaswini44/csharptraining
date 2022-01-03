using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServiceTax
{
    class Student2
    {
        private int rollno;
        private string name;
        private string course;
        private int feepaid;

        private static double servicetax = 12.3;

        public Student2(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }

        public void Payment(int amount)
        {
            feepaid += amount;
        }

        public void Print()
        {
            Console.WriteLine($"Roll No: {rollno}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Course:{course}");
            Console.WriteLine($"Feepaid:{feepaid}");
        }

        public int DueAmount
        {

            get
            {
                return TotalFee - feepaid;
            }
        }

        public int TotalFee
        {
            get
            {
                double total = course == "c#" ? 2000 : 3000;
                // service tax
                total = total + total * servicetax / 100;
                return (int)total;
            }
        }

        public static double ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
                Console.WriteLine($" servicetax:{servicetax}");
            }
        }
    } // Student2

    class UseStudent2
    {

        public static void Main()
        {

            // Create John and Jane Student Detail Objects
            Student2 JohnStudentDetails = new Student2(1001, "John", "c#");
            Student2 JoeStudentDetails = new Student2(1002, "Joe", "ASP.NET");

            // Call Payment method
            JohnStudentDetails.Payment(600);
            JoeStudentDetails.Payment(500);

            // Print out student details
            JohnStudentDetails.Print();

            Console.WriteLine("\n");


            JoeStudentDetails.Print();
            Console.WriteLine(JohnStudentDetails.DueAmount);
            Console.WriteLine(JoeStudentDetails.DueAmount);


        }
    }
}   

