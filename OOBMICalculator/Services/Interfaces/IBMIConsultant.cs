using System;
using System.Collections.Generic;
using System.Linq;

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
    }
}