using System;

namespace OOBMICalculator.Services.Interfaces
{
    /// <summary>
    /// BMI 健康管理顧問
    /// </summary>
    public interface IBMIConsultant
    {
        /// <summary>
        /// 取得BMI建議
        /// </summary>
        /// <param name="bmi">BMI數值</param>
        /// <returns>建議</returns>
        string GetConsultantReport(double bmi);

        /// <summary>
        /// 計算BMI
        /// </summary>
        /// <param name="weight">體重</param>
        /// <param name="tall">身高</param>
        /// <returns>BMI</returns>
        double CalculatingBMI(decimal weight, decimal tall);
    }
}