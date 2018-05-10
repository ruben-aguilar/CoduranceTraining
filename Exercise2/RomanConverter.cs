using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class RomanConverter
    {
        public string Convert(int numberToConvert)
        {
            var result = string.Empty;

            switch (numberToConvert)
            {
                case 10:
                    return "x";
                case 100:
                    return "c";
                case 1000:
                    return "m";
            }

            if (numberToConvert < 10)
            {
                return GetRoman(numberToConvert, "i", "v", "x");
            }

            if (numberToConvert < 100)
            {
                var num = numberToConvert.ToString().ToList();
                result += GetRoman(int.Parse(num[0].ToString()), "x", "l", "c");
                result += GetRoman(int.Parse(num[1].ToString()), "i", "v", "x");
                return result;
            }

            if (numberToConvert < 1000)
            {
                var num = numberToConvert.ToString().ToList();
                result += GetRoman(int.Parse(num[0].ToString()), "c", "d", "m");
                result += GetRoman(int.Parse(num[1].ToString()), "x", "l", "c");
                result += GetRoman(int.Parse(num[2].ToString()), "i", "v", "x");
                return result;
            }

            if (numberToConvert < 10000)
            {
                var num = numberToConvert.ToString().ToList();
                var length = num.Count();
                var thousands = int.Parse(num[0].ToString());
                for (int i = 0; i < thousands; i++)
                {
                    result += "m";
                }
                result += GetRoman(int.Parse(num[1].ToString()), "c", "d", "m");
                result += GetRoman(int.Parse(num[2].ToString()), "x", "l", "c");
                result += GetRoman(int.Parse(num[3].ToString()), "i", "v", "x");
            }

            return result;
        }

        private string GetRoman(int numberToConvert, string one, string five, string ten)
        {
            if (numberToConvert == 4) return one+five;
            if (numberToConvert == 5) return five;
            if (numberToConvert == 9) return one+ten;

            string result = string.Empty;

            if (numberToConvert >= 5)
            {
                result = five;
                numberToConvert -= 5;
            }

            for (int j = 0; j < numberToConvert; j++)
            {
                result += one;
            }

            return result;
        }
    }
}
