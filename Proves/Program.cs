using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proves
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = new DateTime(1999,06,19);
            DateTime b = DateTime.Now;

            Console.WriteLine(IsUnder16(DateTime.Now.AddYears(-16).AddDays(1)));
            Console.ReadKey();
        }

        public static bool IsUnder16(DateTime Birthdate)
        {
            Console.WriteLine(DateTime.Now.Subtract(Birthdate).Days / 365.25);
            Console.WriteLine(DateTime.Now.Subtract(Birthdate).TotalDays / 365.25);
            return DateTime.Now.Subtract(Birthdate).TotalDays / 365.25 < 16;
        }
    }
}
