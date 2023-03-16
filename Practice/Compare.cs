using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Compare
    {
        public static void numbers()
        {
            Console.WriteLine("Enter a number");
            int n1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a number");
            int n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a number");
            int n3 = int.Parse(Console.ReadLine());
            if(n1>n2)
            {
       
                Console.WriteLine("n1 is largest number");
            }
            else if(n2>n3) 
            {
                Console.WriteLine("n2 is largest");

            }
            else
            {
                Console.WriteLine("n3 is largest");
            }
                
           
        }
    }
}
