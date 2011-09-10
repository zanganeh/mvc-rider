using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerManager.CalculatorClient client = new ServerManager.CalculatorClient();
            Console.WriteLine("This is a client");
        }
    }
}