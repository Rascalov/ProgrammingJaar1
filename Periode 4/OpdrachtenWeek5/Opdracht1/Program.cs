﻿using System;
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
            // hier hoorde eigenlijk de start
            MainSystem mainSystem = new MainSystem();
            mainSystem.DoSomeMainWork();
            // hier hoorde eigenlijk de finish
            Console.ReadKey();
            
        }
    }
}
