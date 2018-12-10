using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class LeesTools
    {
        /// <summary>
        ///  Deze methode leest een integer en geeft die waarde terug.
        /// </summary>
        public static int LeesInt(string vraag)
        {
            int invoer;
            Console.Write(vraag);
            invoer = int.Parse(Console.ReadLine());
            return invoer;
        }
        /// <summary>
        ///  Deze methode leest een getal in tussen bepaalde parameters.
        /// </summary>
        public static int LeesInt(string vraag, int min, int max)
        {
            int invoer;

            do
            {
                invoer = LeesInt(vraag);
            } while (invoer > max || invoer < min);
            return invoer;
        }
        /// <summary>
        /// Deze methode leest een string in.
        /// </summary>
        public static string LeesString(string vraag)
        {
            string invoer;
            Console.Write(vraag);
            invoer = Console.ReadLine();
            return invoer;
        }
    }
}
