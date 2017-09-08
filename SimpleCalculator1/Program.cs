using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an expression: ");
            String Input = Console.ReadLine();
            String[] parts = Input.Split(' ');


            int firstnum = Convert.ToInt32(parts[0]);
            int secondnum = Convert.ToInt32(parts[2]);
            String op = parts[1];
            int answer = 0;

            if(op == "+")
            {
                answer = firstnum + secondnum;

            }

            if (op == "-")
            {
                answer = firstnum - secondnum;

            }

            if (op == "*")
            {
                answer = firstnum * secondnum;

            }

            if (op == "/")
            {
                answer = firstnum / secondnum;

            }



            Console.Write(answer);
        }
    }
}
