using System;
using System.Collections.Generic;
using System.Linq;
using OOBMICalculator.Entity;
using OOBMICalculator.Services.Interfaces;

namespace OOBMICalculator.Services
{
    /// <summary>
    /// BMI健康管理顧問
    /// </summary>
    public class BMIConsultant : IBMIConsultant
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="bmiCalculatorService">IBMICalculatorService</param>
        public BMIConsultant(IBMICalculatorService bmiCalculatorService)
        {
            this.BMICalculatorService = bmiCalculatorService;
        }

        /// <summary>
        /// Get or set IBMICalculatorService
        /// </summary>
        public IBMICalculatorService BMICalculatorService { get; set; }

        /// <summary>
        /// 取得BMI健康管理報告
        /// </summary>
        /// <param name="human">案例資料</param>
        /// <returns>報告</returns>
        public string GetBMIHealthyCheckReport(Human human)
        {
            var bmi = this.BMICalculatorService.Calculating(human.Weight, human.Tall);

            var report = this.GetConsultantReport(bmi);

            return report;
        }

        /// <summary>
        /// 取得顧問報告
        /// </summary>
        /// <param name="bmi">BMI數值</param>
        /// <returns>報告</returns>
        private string GetConsultantReport(double bmi)
        {
            if (bmi <= 18)
            {
                return "過瘦";
            }
            else if (bmi >= 24)
            {
                return "過胖";
            }
            else
            {
                return "適中";
            }
        }
    }
}