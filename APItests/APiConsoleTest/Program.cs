using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;



namespace APiConsoleTest
{
    
    class Program
    {
        WebClient wc = new WebClient();
        

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {



            string valuta;
            string value;

            Console.Write("geef een valuta(USD, EUR, CAD): ");
            valuta = Console.ReadLine();

            Console.Write("geef een waarde(in {0}): ", valuta);
            value = Console.ReadLine();
           var json = wc.DownloadString("https://blockchain.info/tobtc?currency="+valuta +"&value="+ value);

               
           Console.Write(value + " in "+ valuta +" is " + json + " bitcoins");
                
            
            Console.ReadKey();
        }
    }
}
