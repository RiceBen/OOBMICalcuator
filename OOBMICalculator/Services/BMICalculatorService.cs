using System;
using OOBMICalculator.Services.Interfaces;

namespace OOBMICalculator.Services
{
    /// <summary>
    /// BMI 計算機
    /// </summary>
    public class BMICalculatorService : IBMICalculatorService
    {
        /// <summary>
        /// 計算BMI
        /// </summary>
        /// <param name="weight">體重</param>
        /// <param name="tall">身高</param>
        /// <returns>BMI</returns>
        public double Calculating(decimal weight, decimal tall)
        {
            this.Validator(weight, tall);

            tall = tall / 100;

            var bmi = (double)weight / Math.Pow((double)tall, 2.0);

            return bmi;
        }

        /// <summary>
        /// 驗證資料
        /// </summary>
        /// <param name="weight">體重</param>
        /// <param name="tall">身高</param>
        private void Validator(decimal weight, decimal tall)
        {
            if (weight <= 0 || tall <= 0)
            {
                throw new ArgumentException("身高/體重輸入錯誤");
            }
        }
    }
}