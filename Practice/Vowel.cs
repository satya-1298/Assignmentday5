using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Vowel
    {
        public static void consonant()
        {

            Console.WriteLine("Enter a Letter");
            char l = char.Parse(Console.ReadLine());
            if (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u' ||
                l == 'A' || l == 'E' || l == 'I' || l == 'O' || l == 'U')
            {
                Console.WriteLine("It is a Vowel");

            }
            else
            {
                Console.WriteLine("It is a Consonant");
            }
        }
    }
}

