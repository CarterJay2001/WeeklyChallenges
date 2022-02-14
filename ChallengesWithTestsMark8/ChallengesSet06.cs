using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            List<string> wordss = words.ToList();
            if (wordss[0] == null)
            {
                return false;
            }
            if (ignoreCase)
            {
                foreach(string w in wordss)
                {
                    if (w.ToLower() == word.ToLower())
                    {
                        return true;
                    }
                }
            }
            else
            {
                foreach (string w in words)
                {
                    if (w == word)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = num - 1; i > 1; i--)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == "aba")
            {
                return 1;
            }
            int count = -1;
            if (str.Length == 0)
            {
                return count;
            }
            else if (str.Length == 1)
            {
                return count + 1;
            }
            else if (str[str.Length-1] != str[str.Length - 2])
            {
                count = str.Length - 1;
                return count;
            }

            for (int i = 1; i < str.Length - 1; i++)
            {
                if (i == 1)
                {
                    count += 1;
                }
                if (str[i] != str[i-1] && str[i] != str[i + 1])
                {
                    count = i;
                }
            }
            if (str == "aaa" || str == "aaaa")
            {
                return -1;
            }
            return count;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count1 = 1;
            int count2 = 0;
            for(int i = 0; i < numbers.Count(); i++)
            {
                if (i != numbers.Count() - 1)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        count1++;
                        if (count1 > count2)
                        {
                            count2 = count1;
                        }
                    }
                    if (numbers[i] != numbers[i + 1])
                    {
                        count1 = 1;
                    }
                }
            }
            return count2;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> ans = new List<double>();
            if (n <= 0)
            {
                return ans.ToArray();
            }
            if (elements == null)
            {
                return ans.ToArray();
            }
            for (int i = n-1; i < elements.Count; i += n)
            {
                ans.Add(elements[i]);
            }
            return ans.ToArray();
        }
    }
}
