using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your favorite food? ");
            String food = Console.ReadLine();
            
            if ( food == "pizza")
            {
                Console.Write("Most excellent and correct!  Pizza is indeed one of the best foods ever put on this earth. ");
            }

            else
            {
                Console.Write("Wrong!  That is a terrible choice and you should feel bad about yourself.   Your favorite should be pizza! ");
            }
        }
    }
}
