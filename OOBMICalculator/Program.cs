using System;
using System.Collections.Generic;
using System.Linq;

namespace OOBMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入身高?");
            decimal tall;
            decimal.TryParse(Console.ReadLine(), out tall);

            Console.WriteLine("請輸入體重?");
            decimal weight;
            decimal.TryParse(Console.ReadLine(), out weight);

            Console.WriteLine($"身高:{tall}, 體重:{weight}");

            Console.Read();
        }
    }
}
