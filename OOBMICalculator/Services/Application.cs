using OOBMICalculator.Services.Interfaces;
using System;

namespace OOBMICalculator.Services
{
    /// <summary>
    /// 計算BMI值應用主程式
    /// </summary>
    public class Application : IApplication
    {
        /// <summary>
        /// 執行計算BMI值主程式
        /// </summary>
        public void Run()
        {
            Console.WriteLine("請輸入身高(cm)?");
            decimal tall;
            decimal.TryParse(Console.ReadLine(), out tall);

            Console.WriteLine("請輸入體重(kg)?");
            decimal weight;
            decimal.TryParse(Console.ReadLine(), out weight);

            var BMI = (double)weight / Math.Pow((double)tall / 100, 2.0);

            Console.WriteLine($"身高:{tall}, 體重:{weight}, BMI:{BMI:0.000}");

            Console.Read();
        }
    }
}