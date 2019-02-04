using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Opdracht3
{
    class Program
    {
        const string F1_RESULTATEN = "../../../F1-uitslagen-2018.csv";
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            List<F1Result> resultaten = LeesF1Resultaten(F1_RESULTATEN);
            ToonCoureurPunten(GetCoureurPunten(resultaten));
            ToonOngewijzigdeTop3Races(resultaten);
            Console.ReadKey();
        }
        List<F1Result> LeesF1Resultaten(string bestand)
        {
            if (!File.Exists(bestand))
            {
                Console.WriteLine("Geen bestand gevonden");
                return null;
            }
            List<F1Result> F1Resultaten = new List<F1Result>();
            StreamReader reader = new StreamReader(bestand);
            while (!reader.EndOfStream)
            {
                string[] resultaten = reader.ReadLine().Split(',');
                F1Result result = new F1Result();
                result.RaceNummer = int.Parse(resultaten[0]);
                result.Ranking = int.Parse(resultaten[1]);
                result.Coureur = resultaten[2];
                result.Team = resultaten[3];
                result.StartPositie = int.Parse(resultaten[4]);
                F1Resultaten.Add(result);
            }
            reader.Close();
            return F1Resultaten;
        }
        Dictionary<string, int> GetCoureurPunten(List<F1Result> resultaten)
        {
            Dictionary<string, int> puntenCoureur = new Dictionary<string, int>();
            foreach (F1Result resultaat in resultaten)
            {
                string naam = resultaat.Coureur;
                int punten;
                switch (resultaat.Ranking)
                {
                    case 1:
                        punten = 25;
                        break;
                    case 2:
                        punten = 18;
                        break;
                    case 3:
                        punten = 15;
                        break;
                    case 4:
                        punten = 12;
                        break;
                    case 5:
                        punten = 10;
                        break;
                    case 6:
                        punten = 8;
                        break;
                    case 7:
                        punten = 6;
                        break;
                    case 8:
                        punten = 4;
                        break;
                    case 9:
                        punten = 2;
                        break;
                    case 10:
                        punten = 1;
                        break;

                    default:
                        punten = 0;
                        break;
                }
                if (puntenCoureur.ContainsKey(naam))
                {
                    puntenCoureur[naam] += punten;
                }
                else
                {
                    puntenCoureur.Add(naam, punten);
                }
                
            }
            return puntenCoureur;
        }
        void ToonCoureurPunten(Dictionary<string, int> coureurPunten)
        {
            int count = 1;
            foreach (KeyValuePair<string, int> naam in coureurPunten)
            {
                Console.Write("{0,2}. ", count);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0,-20}", naam.Key);
                Console.ResetColor();
                Console.Write(naam.Value + "\n");
                count++;
            }
            Console.WriteLine();
            int totaal = 0;
            foreach (KeyValuePair<string, int> naam in coureurPunten)
            {
                totaal += naam.Value;
            }
            Console.WriteLine("Total points: {0}", totaal);
        }

        void ToonOngewijzigdeTop3Races(List<F1Result> resultaten)
        {
            bool[] checks = new bool[21];
            for (int i = 0; i < checks.Length; i++)
            {
                checks[i] = true;
            }
            for (int i = 0; i < checks.Length; i++)
            {
                if (resultaten[i].Ranking == 1 || resultaten[i].Ranking < 4)
                {
                    if (resultaten[i].Ranking != resultaten[i].StartPositie)
                    {
                        checks[i] = false;
                    }
                }
                else
                {
                    checks[i] = false;
                }
            }
            Console.WriteLine();
            Console.WriteLine("circuits with unchanged top 3");
            for (int i = 0; i < checks.Length; i++)
            {
                
                if (checks[i])
                {
                    Console.WriteLine("circuit {0}", i);
                }
            }
        
            
        }
    }
}
