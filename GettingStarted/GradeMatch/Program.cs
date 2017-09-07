using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the grade: ");
            String grade = Console.ReadLine().ToUpper();
            String letter = "";
            if (grade == "E")
            {
                letter = "Excellent";
            }

            if (grade == "V")
            {
                letter = "Very Good";
            }

            if (grade == "G")
            {
                letter = "Good";
            }

            if (grade == "A")
            {
                letter = "Average";
            }

            if (grade == "F")
            {
                letter = "Fail";
            }
            Console.Write(" You have chosen: " + letter);


        }
    }
}
