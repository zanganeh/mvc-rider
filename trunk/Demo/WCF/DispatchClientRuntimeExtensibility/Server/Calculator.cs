using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("The values has been pass a='{0}', b='{1}'", a, b);
            return a + b;
        }
    }
}
