using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class Pencil : IPencil
    {
        public bool CanWrite { get{ return nrOfCharsWritten < maxToWrite; } }
        private int maxToWrite;
        private int nrOfCharsWritten;
        public Pencil(int maxToWrite)
        {
            this.maxToWrite = maxToWrite;
        }
        public void AfterSharpening()
        {
            nrOfCharsWritten = 0;   
        }
        public void Write(string message)
        {
            switch (message)
            {
                case "sharpen":
                    PencilSharpener p = new PencilSharpener();
                    p.Sharpen(this);
                    break;
                default:
                    string output = "";
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 0; i < message.Length; i++)
                    {
                        if (CanWrite)
                        {
                            output += message[i];
                            nrOfCharsWritten++;
                        }
                        else
                        {
                            output += "#";
                        }
                    }
                    Console.WriteLine(output);
                    Console.ResetColor();
                    break;
            }
        }
    }
}
