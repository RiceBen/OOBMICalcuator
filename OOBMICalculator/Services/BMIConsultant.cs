﻿using System;
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
        /// 計算BMI
        /// </summary>
        /// <param name="weight">體重</param>
        /// <param name="tall">身高</param>
        /// <returns>BMI</returns>
        public double CalculatingBMI(decimal weight, decimal tall)
        {
            return this.BMICalculatorService.Calculating(weight, tall);
        }

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