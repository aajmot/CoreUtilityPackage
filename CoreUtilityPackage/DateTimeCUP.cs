using System;
using System.Collections.Generic;
using System.Text;

namespace CoreUtilityPackage
{
    /// <summary>
    /// DateTime related funcion for implementing basic requirement
    /// </summary>
    public class DateTimeCUP : BaseCUP, IDateTimeCUP
    {
        /// <summary>
        /// Check if input string value is valid datetime or return null
        /// </summary>
        /// <param name="inputDateTime">string input for date checking</param>
        /// <returns>null for invalid date or the converted datetime value</returns>
        public DateTime? ParseDateTime(string inputDateTime)
        {
            try
            {
                DateTime? resultDate = null;

                DateTime dt = DateTime.MinValue;
                DateTime.TryParse(inputDateTime, out dt);
                if (dt != null && dt != DateTime.MinValue)
                {
                    resultDate = dt;
                }
                return resultDate;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Check if string input value is a valid date or not
        /// </summary>
        /// <param name="inputDateTime">date string value</param>
        /// <returns>true/false based on the convertability of the inputed value</returns>
        public bool IsValidDateTime(string inputDateTime)
        {
            try
            {
                bool _result = false;

                DateTime dt = DateTime.MinValue;
                DateTime.TryParse(inputDateTime, out dt);
                if (dt != null && dt != DateTime.MinValue)
                {
                    _result = true;
                }
                return _result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
