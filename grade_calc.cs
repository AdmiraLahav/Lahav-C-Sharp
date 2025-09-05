using System;

namespace Lahav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get current grade
            Console.WriteLine("Enter your grade");
            int currentGrade = int.Parse(Console.ReadLine());

            // Get passing grade
            Console.WriteLine("grade needed to pass");
            int neededToPass = int.Parse(Console.ReadLine());

            // Get exam percentage of final grade
            Console.WriteLine("What percentage of the final grade is the next exam");
            int finalExamPercentage = int.Parse(Console.ReadLine());

            // Convert percentage to weight (decimal)
            double examWeight = (double)finalExamPercentage / 100;

            // Check if already passing
            if (currentGrade >= neededToPass && examWeight < 1.0)
            {
                Console.WriteLine("You are already passing");
                return;
            }

            Console.WriteLine("checking grade");

            // Calculate the minimum exam score needed to pass
            double minExamScore = (neededToPass - currentGrade * (1 - examWeight)) / examWeight;

            if (minExamScore > 100)
            {
                Console.WriteLine("It is impossible to pass, even with a perfect exam score.");
            }
            else if (minExamScore < 0)
            {
                Console.WriteLine("You are already passing regardless of the exam.");
            }
            else
            {
                Console.WriteLine("The grade you need to get is " + Math.Ceiling(minExamScore));
            }
        }
    }
}
