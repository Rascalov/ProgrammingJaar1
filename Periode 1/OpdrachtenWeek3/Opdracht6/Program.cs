using System;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie
            int score;
            char grade;
            string passedCheck;

            // invoer
            Console.Write("Enter score: ");
            score = Convert.ToInt32(Console.ReadLine());

            // validatie
            while (score < 0 || score > 100 )
            {
                Console.Write("Enter a valid score: ");
                score = Convert.ToInt32(Console.ReadLine());
            }

            // grade bepaling met conditions
            if (score >= 90)
            {
                grade = 'A';
            }
            else if (score >= 80)
            {
                grade = 'B';
            }
            else if (score < 80 && score >= 70)
            {
                grade = 'C';
            }
            else if (score < 70 && score >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            // controle op voldoende onvoldoende
            if (grade == 'D' || grade == 'F')
            {
                passedCheck = "Course not Passed";
            }
            else
            {
                passedCheck = "Course Passed";
            }




            // output
            Console.WriteLine();
            Console.WriteLine("grade: {0}", grade);
            Console.WriteLine(passedCheck);
            Console.ReadLine();


        }
    }
}
