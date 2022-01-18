using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            return (alphabet.Contains(c.ToString().ToLower())) ? true : false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return Math.Abs(num) % 2 == 1 ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return (numbers == null || numbers.Count() == 0) ? 0 : numbers.Min() + numbers.Max();

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return (numbers == null) ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int ans = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    ans += number;
                }
            }
            return ans;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers == null ? false : (Math.Abs(numbers.Sum()) % 2 == 1) ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number > 0 ? number / 2 : 0;
        }
    }
}
