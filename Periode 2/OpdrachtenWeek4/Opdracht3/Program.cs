using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Program myProgram = new Program();
                myProgram.Start();
            }
            
        }
        void Start()
        {
            Console.Write("Zoek woord: ");
            string woord = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Number of lines containing the word: "+ ZoekWoordInBestand("Tweets.txt", woord));
            Console.ReadKey();
        }

        bool ZitWoordInRegel(string regel, string woord)
        {
            if (regel.ToLower().Contains(woord.ToLower())){
                return true;
            }

            return false;
        }
        int ZoekWoordInBestand(string bestandsnaam, string woord)
        {
            int teller = 0;
            StreamReader reader = new StreamReader(bestandsnaam);
            while (!reader.EndOfStream)
            {
                string regel = reader.ReadLine();
                if (ZitWoordInRegel(regel, woord))
                {
                    ToonWoordInRegel(regel, woord);
                  
                    Console.WriteLine();
                    teller++;
                }
            }
            reader.Close();
            return teller;
        }

        // good spul
        
        void ToonWoordInRegel(string regel, string woord)
        {
            
            List<int> posities = new List<int>();
            int beginPositie;
            
            beginPositie = regel.IndexOf(woord, StringComparison.CurrentCultureIgnoreCase);

            // we maken een lijst van posities waar het woord is gevonden
            while (beginPositie != -1)
            {
                posities.Add(beginPositie);
                beginPositie = regel.IndexOf(woord, beginPositie + woord.Length, StringComparison.CurrentCultureIgnoreCase);
            }

            // per character i kijken we of die gelijk staat aan de begin positie van het zoekwoord.
            for (int i = 0; i < regel.Length; i++)
            {
              
                if (posities.Contains(i))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int j = 0; j < woord.Length; j++)
                    {
                        Console.Write(regel[i+j]);
                    }
                    
                    i = i + woord.Length -1;
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(regel[i]);
                }
                

                
            }
            Console.WriteLine();
        }       














            // tweede poging, probleem: niet volgens de opdracht en maakt meer rood dan nodig.
           /* String[] woorden = regel.Split(' ');
            foreach(string woordV in woorden)
            {
                Console.ResetColor();
                if (woordV.ToLower().Contains(woord.ToLower()))
                {
                    woord = woordV;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(woord + " ");
                    
                }
                else
                {
                    Console.Write(woordV + " ");
                }
            }

            */
            // eerste poging. Problemen: sloom en print naast het zoekwoord( dus hij wordt 2 keer geprint, 1x rood, 1x wit)
            /*string roodWoord;
            int roodLocatie = regel.IndexOf(woord, StringComparison.CurrentCultureIgnoreCase);

           



           

            // if (regel.Substring(roodLocatie, woord.Length) == woord)
            roodWoord = regel.Substring(roodLocatie, woord.Length);
            // Console.Write(regel.Substring(roodLocatie, woord.Length));

            char[] letters = regel.ToCharArray();
            for (int i = 0; i < regel.Length; i++)
            {
                string vergelijk = "";
                try
                {
                     vergelijk = regel.Substring(i, woord.Length);
                }
                catch { }
                
                
                Console.ResetColor();
                if (vergelijk.ToLower().Equals(woord.ToLower()) )
                {
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(regel.Substring(i, woord.Length));
                }
                else
                {
                    Console.Write(letters[i]);
                }
            } */
            

            

            

            

            
        
    }
}
