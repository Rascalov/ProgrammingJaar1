using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4_Lingo
{
    
    class Program
    {
       
        Random rnd = new Random();
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            string path = "/../C#/J1P2W3/Periode 2/woorden.txt";
            Console.WriteLine(ChooseWord(ReadWords(path)));
        }

        List<string> ReadWords(string file)
        {
            List<string> woordenlijst = new List<string>();
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                string woord = reader.ReadLine();
                if (woord.Length == Constanten.LINGO_LETTERS)
                {
                    woordenlijst.Add(woord);
                }
            }
            return woordenlijst;
        }
        string ChooseWord(List<string> woordenlijst)
        {
            return (woordenlijst[rnd.Next(0, woordenlijst.Count)]);
        }

    }
}
