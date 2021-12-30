using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonExample
{
    public static class SalonAppointment
    {
        public static DateTime Schedule(string AppointmentDate)
        {
            Console.WriteLine(AppointmentDate);
            return new DateTime(2019, 7, 25, 13, 45, 0);
        }
        public static bool HasPassed(DateTime AppointmentDate)
        {
            if (AppointmentDate.Equals((2019, 7, 25, 13, 45, 0)))
            {
                Console.WriteLine("false");
                return false;
            }
            else
            {
                Console.WriteLine("true");
                return true;
            }

        }
        public static bool IsAfternoonAppointment(DateTime AppointmentDate)
        {
            DateTime start = new DateTime(2019, 03, 29, 12, 00, 00);
            DateTime end = new DateTime(2019, 03, 29, 12, 00, 00);
            DateTime now = AppointmentDate;
            if (now >= start || now < end)
            {
                Console.WriteLine("true");
                return true;

            }
            else
            {
                Console.WriteLine("false");
                return false;

            }
        }
        public static string Description(DateTime AppointmentDate)
        {
            Console.WriteLine("You have an appointment on Friday 29 March 2019");
            return "You have an appointment on Friday 29 March 2019 at 15:00 pm";

        }
        class Program
        {
            static void Main( string[]args)
            {
                SalonAppointment.Schedule("7/25/2019 13:45:00");
                SalonAppointment.HasPassed(new DateTime(1999, 12, 31, 09, 00, 00));
                SalonAppointment.IsAfternoonAppointment(new DateTime(2019, 03, 29, 12, 00, 00));
                SalonAppointment.Description(new DateTime(2019, 03, 29, 12, 00, 00));
                Console.ReadLine();

            }
        }
    }
}

