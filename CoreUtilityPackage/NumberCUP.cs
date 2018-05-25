using System;
using System.Collections.Generic;
using System.Text;

namespace CoreUtilityPackage
{
    /// <summary>
    /// Number related basic functionality implementation
    /// </summary>
    public class NumberCUP : INumberCUP
    {
        /// <summary>
        /// convert a decimal value to it's number
        /// </summary>
        /// <param name="number">input decimal parameter</param>
        /// <param name="unit">unit for writing the number which basically appear at the end of the string</param>
        /// <returns>Converted number in world</returns>
        public string NumberInWord(decimal number, string unit = "")
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (number < 0)
                {
                    sb.Append("Minus ");
                }
                if (number / 1000000000000 > 0)
                {
                    sb.Append(NumberInWord(number / 1000000000000) + " Trillion ");
                    number %= 1000000000000;
                }
                if (number / 1000000000 > 0)
                {
                    sb.Append(NumberInWord(number / 1000000000) + " Billion ");
                    number %= 1000000000;
                }
                if (number / 1000000 > 0)
                {
                    sb.Append(NumberInWord(number / 1000000) + " Million ");
                    number %= 1000000;
                }
                if (number / 1000 > 0)
                {
                    sb.Append(NumberInWord(number / 1000) + " Thousand ");
                    number %= 1000;
                }
                if (number / 100 > 0)
                {
                    sb.Append(NumberInWord(number / 100) + " Hundred ");
                    number %= 100;
                }

                if (number > 0)
                {
                    if (sb.Length > 0)
                        sb.Append(" and ");

                    var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                    var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                    if (number < 20)
                        sb.Append(unitsMap[Convert.ToInt32(number)]);
                    else
                    {
                        sb.Append(unitsMap[Convert.ToInt32(number) / 10]);
                        if ((number % 10) > 0)
                            sb.Append(unitsMap[Convert.ToInt32(number) % 10]);
                    }
                }
                if (!string.IsNullOrEmpty(unit))
                {
                    sb.Append(unit);
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// If input object is convertable to Int32
        /// </summary>
        /// <param name="input">Input value to convert to Int32</param>
        /// <returns>null or converted INT32 value</returns>
        public Int32? IsInt32(object input)
        {
            try
            {
                Int32? _numer = null;

                if (!string.IsNullOrEmpty(Convert.ToString(input)))
                {
                    int intData = 0;
                    Int32.TryParse(Convert.ToString(input), out intData);
                    if (intData > 0)
                    {
                        _numer = intData;
                    }
                }
                return _numer;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
