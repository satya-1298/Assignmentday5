using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class SwapNumbers
    {
        public static void swap()
        {
            //Console.WriteLine("Enter a Number");
            //int a=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a number");
            //int b=int.Parse(Console.ReadLine());
            int a = 8;
            int b=10;
            Console.WriteLine("value before swaping a=" + a + " b=" + b);
            int n = a * b;
            a =n / a;
            b = n / b;
            
            Console.WriteLine("value after swaping a = " + a + " b = " + b);
        }
    }
}
