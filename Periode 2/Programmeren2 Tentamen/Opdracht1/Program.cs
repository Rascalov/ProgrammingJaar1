using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            const string ALFABET = "abcdefghijklmnopqrstuvwxyz";
            Console.Write("Geef een tekst: ");
            string invoer = Console.ReadLine();
            Console.Write("Geef de sleutel: ");
            string sleutel = Console.ReadLine().ToLower();
            Console.WriteLine($"versleutelde tekst: {VervangTekst(invoer, ALFABET, MaakSubstitutieAlfabet(sleutel, ALFABET))} ");
            Console.ReadKey();
        }
        string MaakSubstitutieAlfabet(string sleutel, string standaardAlfabet)
        {
            string alfabetTemp = sleutel + standaardAlfabet;
            string substitutieAlfabet = "";
            for (int i = 0; i < alfabetTemp.Length; i++)
            {
                if (!substitutieAlfabet.Contains(alfabetTemp[i]))
                {
                    substitutieAlfabet += alfabetTemp[i];
                }
            }
            return substitutieAlfabet;
        }

        string VervangTekst(string input, string standaardAlfabet, string substitutieAlfabet)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                int positie = standaardAlfabet.IndexOf(input[i]);
                if (positie < 0)
                {
                    output += input[i];
                }
                else
                {
                    output += substitutieAlfabet[positie]; 
                }
            }
            return output;
        }
    }
}
