using System;
using System.Collections.Generic;

namespace Opdracht1
{
    class Program
    {
        int teller = 0;
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            List<Course> report = new List<Course>();
            
            Course vak = new Course();

            DisplayReport(ReadReport(report));


            Console.ReadKey();
          

        }

        List<Course> ReadReport(List<Course> list)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a course.");
                list.Add(ReadCourse("Name of the course: "));
                Console.WriteLine();
            }
            
            return list;
        }

        void DisplayReport(List<Course> list)
        {
            foreach(Course vak in list)
            {
                string result = String.Format("{0,-15} : {1}\t {2}", vak.Name, vak.Grade, vak.pGrade);
                Console.WriteLine(result);
            }
            if (Passed(list))
            {
                if (CumLaude(list))
                {
                    Console.WriteLine("Amazing, you graduated cum laude! With (of course) {0} retakes needed", teller);
                }
                else
                {
                    Console.WriteLine("Congratulations, you graduated! {0} retakes needed!", teller);
                }
            }
            else
            {
                Console.WriteLine("Too bad, you did not graduate, you got {0} retake(s).", teller);
            }
        }



        PracticalGrade ReadPracticalGrade(string question)
        {
            // lijst van opties
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + ".  " + (PracticalGrade)i + "  ");
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
            vak.Grade = LeesInt("Grade for " + vak.Name + ": ");
            vak.pGrade = ReadPracticalGrade("Practical grade for " + vak.Name + ": ");

            return vak;
        }
        void DisplayCourse(Course course)
        {
            Console.Write(course.Name);
        }
        public bool Passed(List<Course> vakken)
        {
            
            foreach(Course vak in vakken)
            {
                if (vak.Grade < 55)
                {
                    teller++;
                }
                if (vak.pGrade < PracticalGrade.Sufficient)
                {
                    teller++;
                }
            }
            if (teller != 0)
            {
                return false;
            }


            return true;
        }

        public bool CumLaude(List<Course> vakken)
        {
            foreach (Course vak in vakken)
            {
                if (vak.Grade < 80)
                {
                    return false;
                }
            }
          

            return true;
        }








        // Deze methode leest een integer en geeft die waarde terug.
        int LeesInt(string vraag)
        {
            int invoer;
            Console.Write(vraag);
            Console.ForegroundColor = ConsoleColor.Green;
            invoer = int.Parse(Console.ReadLine());
            Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Green;
            invoer = Console.ReadLine();
            Console.ResetColor();
            return invoer;
        }
    }
}
