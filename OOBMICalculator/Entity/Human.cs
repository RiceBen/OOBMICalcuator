using System;

namespace OOBMICalculator.Entity
{
    /// <summary>
    /// 人
    /// </summary>
    public class Human
    {
        /// <summary>
        /// 性別
        /// </summary>
        public GenderEnum Gender { get; set; }

        /// <summary>
        /// 體重
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// 身高
        /// </summary>
        public decimal Tall { get; set; }
    }
}