using System;
using OOBMICalculator.Entity;

namespace OOBMICalculator.Services.Interfaces
{
    /// <summary>
    /// BMI 健康管理顧問
    /// </summary>
    public interface IBMIConsultant
    {
        /// <summary>
        /// 取得BMI健康管理報告
        /// </summary>
        /// <param name="human">案例資料</param>
        /// <returns>報告</returns>
        string GetBMIHealthyCheckReport(Human human);
    }
}