using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach(bool ans in vals)
            {
                if (!ans)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var sum = numbers.Sum();
            sum = Math.Abs(sum);
            return (sum % 2 == 1) ? true : false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var count = new int[3];
            foreach(char a in password)
            {
                if (Char.IsUpper(a))
                {
                    count[0]++;
                }
            }
            foreach (char b in password)
            {
                if (Char.IsLower(b))
                {
                    count[1]++;
                }
            }
            foreach (char c in password)
            {
                if (Char.IsNumber(c))
                {
                    count[2]++;
                }
            }
            if (count[0] > 0 && count[1] > 0 && count[2] > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            foreach(char a in val)
            {
                return a;
            }
            return 'a';
        }

        public char GetLastLetterOfString(string val)
        {
            char ans = 'a';
            foreach (char a in val)
            {
                ans = a;
            }
            return ans;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var oddsList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    oddsList.Add(i);
                }
            }
            return oddsList.ToArray();
        }

        public string[] ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            return words;
        }
    }
}
