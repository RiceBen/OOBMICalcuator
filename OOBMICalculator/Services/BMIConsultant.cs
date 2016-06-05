using System;
using System.Collections.Generic;
using System.Linq;
using OOBMICalculator.Services.Interfaces;

namespace OOBMICalculator.Services
{
    /// <summary>
    /// BMI健康管理顧問
    /// </summary>
    public class BMIConsultant : IBMIConsultant
    {
        /// <summary>
        /// 取得顧問報告
        /// </summary>
        /// <param name="bmi">BMI數值</param>
        /// <returns>報告</returns>
        public string GetConsultantReport(double bmi)
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