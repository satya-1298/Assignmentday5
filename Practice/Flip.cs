using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Flip
    {
        public static void coin()
        {
            int f = 1;
            int Hcount = 0;
            int Tcount = 0;
            double tail_percentage = 0;
            double head_percentage = 0;
            int head = 0,tail = 0;
            Console.WriteLine("No.of time the coin flip:");
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                    Random random = new Random();
                    int r = random.Next(0,2);
                    Console.WriteLine(r);

                    if (r == 0)
                    {
                        Console.WriteLine("It is tail");
                        //tail =1;
                        Tcount += 1;
                    }
                    else if (r == 1) 
                    {
                        Console.WriteLine("It is head");
                       // head = 1;
                        Hcount += 1;
                    }
                    
            }
            Console.WriteLine(Hcount);
            Console.WriteLine(Tcount);
            tail_percentage = (Tcount * 100) / n;
            head_percentage = (Hcount * 100) / n;
            Console.WriteLine("Tail percentage: " + tail_percentage);
            Console.WriteLine("head percentage:" + head_percentage);
            
        }
    }
}
