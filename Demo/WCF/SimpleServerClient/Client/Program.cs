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
            int a = 2;
            int b = 3;
            ServerManager.CalculatorClient client = new ServerManager.CalculatorClient("NetTcpBinding_ICalculator");
            Console.WriteLine("This is a client");
            var result = client.Add(a, b);
            Console.WriteLine("'Add' function has been called with current parameter : a='{0}',b='{1}' and the result is c='{2}'", a, b, result);
        }
    }
}