using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static bool isPrime(List<int> primes, int n)
        {
            // Find one example where n isn't prime

            // Check every integer in primes to see if n is evenly divisible by it
            foreach (int p in primes)
            {
                if (n % p == 0)
                {
                    return false;
                }
            }

            return true;
        }


        static void Main(string[] args)
        {
            List<int> primes = new List<int>();
            primes.Add(2); // slot 1
            primes.Add(3); // slot 2
            Console.Write(" 2, 3, ");
            int count = 2, n = 5; // n is numbers being tested
            while (count < 1000)
            {
                if (isPrime(primes, n))
                {
                    
                    primes.Add(n); // adds number to list if prime
                    Console.Write(n.ToString().PadLeft(4) + ", ");
                    count++;
                }

                n += 2;
            }
            
        }
    }
}

