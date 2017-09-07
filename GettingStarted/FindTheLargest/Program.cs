using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number: ");
            int third = Convert.ToInt32(Console.ReadLine());

            if (first > second && first > third)
            {
                Console.WriteLine("The first number is the greatest of the three.");
            }

            if (second > first && second > third)
            {
                Console.WriteLine("The second number is the greatest of the three.");
            }


            if (third > first && third > second)
            {
                Console.WriteLine("The third number is the greatest of the three.");
            }


        }
    }
}
