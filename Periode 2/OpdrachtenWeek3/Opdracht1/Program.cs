using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            PracticalGrade pGrade;

            Console.WriteLine("Enter a course.");
            ReadCourse("Name of course");
            ReadPracticalGrade("Practical grade for Programming 1: ");
            DisplayCourse

        }

        PracticalGrade ReadPracticalGrade(string question)
        {
            // lijst van opties
            for (int i = 0; i < 6; i++)
            {
                Console.Write(i + ".  " + (PracticalGrade)1 + "  ");
            }
            Console.WriteLine();
            PracticalGrade pGrade = (PracticalGrade)LeesInt(question);
            return pGrade;
        }
        void DisplayPracticalGrade(PracticalGrade practical)
        {
            Console.Write(practical);
        }

        Course ReadCourse(string question)
        {
            Course vak = new Course();
            
            vak.Name = LeesString(question);
            return vak;
        }
        void DisplayCourse(Course course)
        {
            Console.Write(course.Name);
        }










        // Deze methode leest een integer en geeft die waarde terug.
        int LeesInt(string vraag)
        {
            int invoer;
            Console.Write(vraag);
            invoer = int.Parse(Console.ReadLine());
            return invoer;
        }
        // Deze methode krijgt een invoer binnen en als het tussen de gegeven waardes ligt gaat het programma door, zo niet loopt hij. 
        int LeesInt(string vraag, int min, int max)
        {
            int invoer;

            do
            {
                invoer = LeesInt(vraag);
            } while (invoer > max || invoer < min);
            return invoer;
        }
        // Deze methode leest een string in.
        string LeesString(string vraag)
        {
            string invoer;
            Console.Write(vraag);
            invoer = Console.ReadLine();
            return invoer;
        }
    }
}
