using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {

                Console.WriteLine("Input a username: ");
                String entereduse = Console.ReadLine();
                Console.WriteLine("Input a password: ");
                String enteredpass = Console.ReadLine();

                if ("root" == entereduse)
                {
                    if ("letmein" == enteredpass)
                    {
                        Console.WriteLine("Username and password authenticated... you may proceed");
                    }
                }
                else
                {
                    if (i == 3)
                    {
                        Console.WriteLine("Too many incorrect login attemps. try again later");
                    }
                }
            }
        }
    }
}
