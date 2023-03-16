using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Division
    {
        public static void divi()
        {
            //int dividend = 30;
            //int divisor = 5;
            Console.WriteLine("Enter a Number");
            int dividend=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Number");
            int divisor = int.Parse(Console.ReadLine());

            int Quotient =dividend/divisor;
            int Reminder=dividend%divisor;
            Console.WriteLine("The Quotient is " + Quotient);
            Console.WriteLine("The Reminder is " + Reminder);
        }
    }
}
