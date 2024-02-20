using System;

namespace Demo
{
    public class CodeOptimize
    {
        public string ConcatenateStrings(string str1, string str2)
        {
            string result = "";
            for (int i = 0; i < str1.Length; i++)
            {
                result += str1[i];
            }
            for (int i = 0; i < str2.Length; i++)
            {
                result += str2[i];
            }
            return result;
        }

        public string ReverseString(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }

        public string RemoveWhitespace(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsWhiteSpace(str[i]))
                {
                    result += str[i];
                }
            }
            return result;
        }
    }
}
