using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class StringExtensions
    {
        public static bool IsStringNull(this string s) => s == null;
        public static bool IsStringEmpty(this string s) => s == string.Empty;

        public static string FirstToUpper(this string s)
        {
            try
            {
                return s.Substring(0, 1).ToUpper() + s.Substring(1);
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new Exception(
                    "FirstToUpper Exception: Operation failed. Check the string value for possible errors.");
            }
        }

        public static string ApplySentenceCasing(this string s)
        {
            try
            {
                bool IsNewSentense = true;
                var result = new StringBuilder(s.Length);
                for (int i = 0; i < s.Length; i++)
                {
                    if (IsNewSentense && char.IsLetter(s[i]))
                    {
                        result.Append(char.ToUpper(s[i]));
                        IsNewSentense = false;
                    }
                    else
                        result.Append(s[i]);

                    if (s[i] == '!' || s[i] == '?' || s[i] == '.')
                    {
                        IsNewSentense = true;
                    }
                }

                return result.ToString();
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new Exception(
                    "ApplySentenceCasing Exception: Operation failed. Check the string value for possible errors.");
            }
        }
    }
}
