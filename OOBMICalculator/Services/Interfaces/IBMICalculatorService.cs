using System;

namespace OOBMICalculator.Services.Interfaces
{
    /// <summary>
    /// BMI 計算器介面
    /// </summary>
    public interface IBMICalculatorService
    {
        /// <summary>
        /// 計算BMI
        /// </summary>
        /// <param name="weight">體重</param>
        /// <param name="tall">身高</param>
        /// <returns>BMI</returns>
        double Calculating(decimal weight, decimal tall);
    }
}