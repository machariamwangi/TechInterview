using System.Numerics;

namespace Exercise01
{
    public class CustomeIntergerExtensions
    {
        //The Referece of this solution is from // https://docs.microsoft.com/en-us/dotnet/api/system.numerics.biginteger?view=net-6.0
        

        //This separates via modulas to determine the  'AND" In the Words
        public static string GenerateEndPart(BigInteger value, BigInteger divider)
        {
            BigInteger modulus = value % divider;
            string endPart = modulus == 0 ? "" : $"{(divider == 100 ? "and " : "")}{ConvertToWords(modulus)}";
            return endPart;
        }

        public static string ConvertToWords(BigInteger value)
        {
            string[] uniqueDigits = new string[] {
                "zero", "one", "two", "three", "four",
                "five", "six", "seven", "eight", "nine",
                "ten", "eleven", "twelve",
                "thirteen",  "fourteen", "fifteen", "sixteen",
                "seventeen", "eighteen", "nineteen"
            };

            string[] tensMultiple = new string[] {
                "", "", "twenty",  "thirty", "forty",
                "fifty", "sixty", "seventy", "eighty", "ninety"
            };

            string[] tensPower = new string[] {
                "hundred", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion"
            };
            return null;
        
        }

    }
}