using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataEditor.myClass
{
    public class Number
    {
        public static string toEnglishNumber(string input)
        {
            string EnglishNumbers = "";
            if (input != null)
                for (int i = 0; i < input.Length; i++)
                {
                    if (Char.IsDigit(input[i]))
                    {
                        EnglishNumbers += char.GetNumericValue(input, i);
                    }
                    else
                    {
                        EnglishNumbers += input[i].ToString();
                    }
                }

            return EnglishNumbers;
        }
        public static string toPersianNumber(string englishNumber)
        {
            string persianNumber = "";
            foreach (char ch in englishNumber)
            {
                persianNumber += (char)(1776 + char.GetNumericValue(ch));
            }
            return persianNumber;
        }
        public static string spacer(long input)
        {
            if ( input == 0) return "0";
            string output = converter(Convert.ToDouble(input));
            return output;
        }
        public static string spacer(double input)
        {
            if ( input == 0) return "0";
            string output = converter(Convert.ToDouble(input));
            return output;
        }
        public static string spacer(decimal input)
        {
            if ( input == 0) return "0";
            string output = converter(Convert.ToDouble(input));
            return output;
        }
        public static string spacer(int input)
        {
            if (input == 0) return "0";
            string output = converter(Convert.ToDouble(input));
            return output;
        }

        public static string spacer(int? input)
        {
            if ( input == 0) return "0";
            string output = converter(Convert.ToDouble(input));
            return output;
        }
        public static string spacer(long? input)
        {
            if ( input == 0) return "0";
            string output = converter(Convert.ToDouble(input));
            return output;
        }
        public static string spacer(double? input)
        {
            if ( input == 0) return "0";
            string output = converter(Convert.ToDouble(input));
            return output;
        }
        public static string spacer(decimal? input)
        {
            if ( input == 0) return "0";
            string output = converter(Convert.ToDouble(input));
            return output;
        }

        private static string converter(double input)
        {
            string Text = input.ToString("n0");
            return Text;
        }
    }
}
