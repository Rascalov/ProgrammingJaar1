using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoordenHusselen
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
            Console.Write("Geef een zin: ");
            string zin = Console.ReadLine();
            Console.WriteLine(HusselZinWoorden(zin));
            Console.ReadKey();
        }

        string HusselZinWoorden(string zin)
        {
            string[] woorden = zin.Split(' ');
            string husselZin = "";
            foreach (string woord in woorden)
            {
                husselZin = husselZin + HusselWoord(woord) + " ";

            }
            return husselZin;
        }

        string HusselWoord(string woord)
        {
            Random rnd = new Random();
            if (woord.Length < 3)
            {
                return woord;
            }
            string niewuWoord = Convert.ToString(woord[0]);
            string restWoord = woord.Substring(1, woord.Length-2);

            while (restWoord != "")
            {
                int random = rnd.Next(0, restWoord.Length);
                niewuWoord = niewuWoord + restWoord[random];
                restWoord = restWoord.Remove(random, 1);
                
            }
            niewuWoord = niewuWoord + woord[woord.Length - 1];
            return niewuWoord;
        }
    }
}
