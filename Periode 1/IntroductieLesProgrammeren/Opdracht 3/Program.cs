using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 200;
            int level = 3;
            int aantalItems = 4;
            int score_nieuw, level_nieuw;
            // Fout: = score++ doet het volgende: score_nieuw wordt gelijk gesteld aan score, 
            // DAARNA krijgt score + 1 erbij, waardoor het niet klopt
            // fix: score + 1, ipv score++
             score_nieuw = score + 1;
            // Fix: level + 1 ipv ++level
            // Fout: = ++level geeft int level eerst 1 erbij, daarna wordt level_nieuw gelijk aan level.
             level_nieuw = level + 1;

            // verschil tussen var++ en ++var is de volgorde die wordt gevolgd,
            // = var++ maakt het variabel eerst gelijk aan var en geeft daarna pas var +1
            // = ++var geeft var eerst +1 en daarna wordt het variabel gelijk aan var.
            // Leraar (ontzettend aardige gozer) adviseerd om het PostIncrement and PreIncrement te noemen
            // ++var is PreIncrement, var++ is PostIncrement.
            Console.WriteLine("Score (oud): {0}, score (nieuw): {1}", score, score_nieuw);
            Console.WriteLine("level (oud): {0}, level (nieuw): {1}", level, level_nieuw);
            aantalItems += 5;
            Console.WriteLine("aantal items: {0}", aantalItems);
            // wacht totdat de gebruiker een toets indrukt
            Console.ReadKey();

        }
    }
}
