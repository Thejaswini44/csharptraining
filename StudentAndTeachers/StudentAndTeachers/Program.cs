using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndTeachers
{
    class StudentAndTeacherTest
    {
        static void Main()
        {
            bool debug = false;

            
            Person myPerson = new Person();
            myPerson.Greet();

      
            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

           
            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();

            if (debug)
                Console.ReadLine();
        }
    }
}
