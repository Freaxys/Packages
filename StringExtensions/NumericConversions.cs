using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class NumericConversions
    {
        public static int? ToInt(this string s)
        {
            try
            {
                return s == null ? null : Convert.ToInt32(s);
            } catch(Exception)
            {
                throw new Exception(
                    "ToInt Exception: Failed to convert string to int. " +
                    "Check the string value for possible errors.");
            }
        }

        public static double? ToDouble(this string s)
        {
            try
            {
                return s == null ? null : Convert.ToDouble(s, CultureInfo.InvariantCulture);
            } catch(Exception)
            {
                throw new Exception(
                    "ToDouble Exception: Failed to convert string to double. " +
                        "Check the string value for possible errors.");
            }
        }

        public static decimal? ToDecimal(this string s)
        {
            try
            {
                return s == null ? null : Convert.ToDecimal(s, CultureInfo.InvariantCulture);
            } catch(Exception)
            {
                throw new Exception(
                    "ToDouble Exception: Failed to convert string to decimal. " +
                        "Check the string value for possible errors.");
            }
        }

        public static float? ToFloat(this string s)
        {
            try
            {
                return s == null ? null : float.Parse(s, NumberStyles.Float, CultureInfo.InvariantCulture);
            } catch(Exception)
            {
                throw new Exception(
                    "ToDouble Exception: Failed to convert string to float. " +
                        "Check the string value for possible errors.");
            }
        }
    }
}
