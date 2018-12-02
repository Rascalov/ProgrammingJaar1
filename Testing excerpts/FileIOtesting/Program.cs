using System;
using System.IO;

namespace FileIOtesting
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
            string filePath = System.IO.Path.GetFullPath("fetchme.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null){
                        Console.WriteLine(line);
                    }
                }


            } catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
