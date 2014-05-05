using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCalcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCalcSvcProxy.ISimpleCalculator proxy = new MyCalcSvcProxy.SimpleCalculatorClient();
            Console.WriteLine("5+5=" + proxy.Add(5, 6).ToString());
            Console.ReadLine();
        }
    }
}
