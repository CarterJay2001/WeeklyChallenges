using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            for (int i = startNumber + 1; i > 0; i++)
            {
                if (i % n == 0)
                {
                    return i;
                }

            }
            return 0;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var bus in businesses)
            {
                if (bus.TotalRevenue == 0d)
                {
                    bus.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            if (numbers.Length == 1)
            {
                return true;
            }
           

            int count = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] <= numbers[i + 1])
                {
                    count++;
                }
            }
            return (count == numbers.Length);
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i+1];
                }
            }
            return (sum);
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0 || words[0] == " ")
            {
                return "";
            }
            string ans = String.Join(" ", words);
            ans = ans.Replace("  ", " ");
            ans = ans.Replace("   ", " ");
            ans = ans.Replace("  ", " ");
            ans = ans.Replace("   ", " ");
            if (ans[ans.Length-1] == ' ')
            {
                ans = ans.Remove(ans.Length - 1);
            }
            ans += ".";
            return ans;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> ans = new List<double>();
            if (elements == null)
            {
                return ans.ToArray();
            }
            for (int i = 3; i < elements.Count; i+= 4)
            {
                ans.Add(elements[i]);
            }
            return ans.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == targetNumber)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
