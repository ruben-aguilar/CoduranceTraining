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
            return GetRoman(numberToConvert, "i", "v", "x");
        }

        private string GetRoman(int numberToConvert, string one, string five, string ten)
        {
            if (numberToConvert == 5) return five;
            if (numberToConvert == 10) return ten;

            string result = string.Empty;

            if (numberToConvert > 10)
            {
                result = ten;
                for (int j = 0; j < numberToConvert - 10; j++)
                {
                    result += one;
                    if (result.Equals(ten + one + one + one + one))
                    {
                        result = ten + one + five;
                    }
                }
                return result;
            }

            if (numberToConvert > 5)
            {
                result = five;
                for (int j = 0; j < numberToConvert - 5; j++)
                {
                    result += one;
                    if (result.Equals(five + one + one + one + one))
                    {
                        result = one + ten;
                    }
                }
                return result;
            }

            for (int j = 0; j < numberToConvert; j++)
            {
                result += one;
                if (result.Equals(one + one + one + one))
                {
                    result = one + five;
                }
            }

            return result;
        }
    }
}
