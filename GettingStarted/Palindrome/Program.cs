using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Phrase: ");
            String phrase = Console.ReadLine();
            char[] reverse = phrase.ToCharArray();
            Array.Reverse(reverse);
           
            String pal = new String(reverse);
            if (pal == phrase)
            {
                Console.Write("\"" + phrase + "\" is a palindrome.");
            }
             else
            {
                Console.Write("\"" + phrase + "\" is not a palindrome.");
            }
        }
    }
}
