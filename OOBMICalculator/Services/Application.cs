using System;
using OOBMICalculator.Services.Interfaces;

namespace OOBMICalculator.Services
{
    /// <summary>
    /// 計算BMI值應用主程式
    /// </summary>
    public class Application : IApplication
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="bmiConsultant">IBMIConsultant</param>
        public Application(IBMIConsultant bmiConsultant)
        {
            this.BMIConsultant = bmiConsultant;
        }

        /// <summary>
        /// BMI健康管理顧問
        /// </summary>
        public IBMIConsultant BMIConsultant { get; set; }

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

            var BMI = this.BMIConsultant.CalculatingBMI(weight, tall);

            var report = this.BMIConsultant.GetConsultantReport(BMI);

            Console.WriteLine($"身高:{tall}, 體重:{weight}, BMI:{BMI:0.000}");

            Console.WriteLine($"健康評語:{report}");

            Console.Read();
        }
    }
}