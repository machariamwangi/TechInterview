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

            if (value < 0)
            {
                value *= -1;
            }

            if (value < 20)
            {
                return uniqueDigits[(int)value];
            }

            if (value < 100)
            {
                int modulus = (int)value % 10;
                return $"{tensMultiple[(int)value / 10]} {(modulus == 0 ? "" : uniqueDigits[modulus])}";
            }

            // Hundred
            if (value < 1000)
            {
                int divider = 100;
                return $"{ConvertToWords(value / divider)} {tensPower[0]} {GenerateEndPart(value, divider)}";
            }

            // Thousand
            if (value < 1_000_000)
            {
                int divider = 1_000;
                return $"{ConvertToWords(value / divider)} {tensPower[1]} {GenerateEndPart(value, divider)}";
            }

            // Million
            if (value < 1_000_000_000)
            {
                int divider = 1_000_000;
                return $"{ConvertToWords(value / divider)} {tensPower[2]} {GenerateEndPart(value, divider)}";
            }

            // Billion
            if (value < 1_000_000_000_000)
            {
                int divider = 1_000_000_000;
                return $"{ConvertToWords(value / divider)} {tensPower[3]} {GenerateEndPart(value, divider)}";
            }

            // Trillion
            if (value < 1_000_000_000_000_000)
            {
                BigInteger divider = 1_000_000_000_000;
                return $"{ConvertToWords(value / divider)} {tensPower[4]} {GenerateEndPart(value, divider)}";
            }

            // Quadrillion
            if (value < 1_000_000_000_000_000_000)
            {
                BigInteger divider = 1_000_000_000_000_000;
                return $"{ConvertToWords(value / divider)} {tensPower[5]} {GenerateEndPart(value, divider)}";
            }

            // Quintillion 18,456,002,032,011,000,007 //18456002032011000007
            if (value < 10_000_000_000_000_000_000)
            {
                BigInteger divider = 1_000_000_000_000_000_000;
                return $"{ConvertToWords(value / divider)} {tensPower[6]} {GenerateEndPart(value, divider)}";
            }
            if (value < 18_446_744_073_709_551_615)//18,446,744,073,709,551,615  being the  maxima ulong or big Interger
            {
                BigInteger divider = 1_000_000_000_000_000_000;
                return $"{ConvertToWords(value / divider)} {tensPower[6]} {GenerateEndPart(value, divider)}";
            }
            //the biggest integer literal you can define in c# is ulong with max value of 18,446,744,073,709,551,615 (larger values leads to compile error), 
            //which is obviously not enough in your case, easy solution would be to use BigInteger.Parse 
            var num = "91389681247993671255432112000000";
            var longInteger = BigInteger.Parse(num);

            if (value <= longInteger) //18,446,744,073,709,551,615 //
            {
                BigInteger divider = 1_000_000_000_000_000_000;
                return $"{ConvertToWords(value / divider)} {tensPower[6]} {GenerateEndPart(value, divider)}";
            }
            //Return any Number bigger than 91389681247993671255432112000000 is not supported
            return $"{value} is not supported";

        }

    }
}