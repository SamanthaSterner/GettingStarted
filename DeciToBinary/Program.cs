using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeciToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            int quot;

            string rem = "";

            while (num >= 1)
            {
                quot = num / 2;
                rem += (num % 2).ToString();
                num = quot;
            }

            // Reversing the  value
            string bin = "";
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];

            }

            Console.WriteLine("Result: {0}", bin);
        }
    }
}
