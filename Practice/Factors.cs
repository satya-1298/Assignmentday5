using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Factors
    {
        public static void ofnumber()
        {
            Console.WriteLine("Enter a number");
            int n=int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= n; i++) 
            {
               if(n%i==0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
