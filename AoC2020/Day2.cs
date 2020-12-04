using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    public static class Day2
    {
        public static int PartOne(List<string> input)
        {
            // Sample input: 
            // 13-16 k: kkkkkgmkbvkkrskhd

            int validPasswords = 0;

            foreach (var line in input)
            {
                string[] inputSplit = line.Split(' ');

                string[] charRangeSplit = inputSplit[0].Split('-');

                int lowerBound = int.Parse(charRangeSplit[0]);

                int upperBound = int.Parse(charRangeSplit[1]);

                char charToValidate = inputSplit[1][0];

                string password = inputSplit[2];

                int charCount = 0;

                for (var i = 0; i < password.Length; i++)
                {
                    if (password[i] == charToValidate)
                    {
                        charCount++;
                    }
                }

                if (charCount >= lowerBound && charCount <= upperBound)
                {
                    validPasswords++;
                }
            }

            return validPasswords;
        }

        public static int PartTwo(List<string> input)
        {

            // Sample input: 
            // 13-16 k: kkkkkgmkbvkkrskhd

            int validPasswords = 0;

            foreach (var line in input)
            {
                string[] inputSplit = line.Split(' ');

                string[] charRangeSplit = inputSplit[0].Split('-');

                int lowerBound = int.Parse(charRangeSplit[0]);

                int upperBound = int.Parse(charRangeSplit[1]);

                char charToValidate = inputSplit[1][0];

                string password = inputSplit[2];

                if (password.Length < upperBound || password.Length < lowerBound)
                {
                    continue;
                }

                if ((password[lowerBound - 1] == charToValidate && password[upperBound - 1] != charToValidate) || (password[lowerBound - 1] != charToValidate && password[upperBound - 1] == charToValidate))
                {
                    validPasswords++;
                }
            }

            return validPasswords;
        }
    }
}
