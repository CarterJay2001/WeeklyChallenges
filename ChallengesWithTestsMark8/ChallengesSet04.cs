using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int add = 0;
            int sub = 0;
            foreach(int num in numbers)
            {
                if (num % 2 == 0)
                {
                    add += num;
                }
                else
                {
                    sub += num;
                }
            }
            return add - sub;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return Math.Min(str1.Length, Math.Min(str2.Length, Math.Min(str3.Length, str4.Length)));
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(number1, Math.Min(number2, Math.Min(number3, number4)));
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool check1 = sideLength1 > 0 && sideLength2 > 0 && sideLength3 > 0;
            bool check2 = sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength3 + sideLength2 > sideLength1;

            return check1 && check2 ? true : false;
        }

        public bool IsStringANumber(string input)
        {
            return Double.TryParse(input, out double result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count = 0;
            int other = 0;
            foreach(var thing in objs)
            {
                if (thing == null)
                {
                    count++;
                }
                else
                {
                    other++;
                }
            }

            return count > other ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double count = 0;
            if (numbers == null)
            {
                return 0;
            }

                foreach (double num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }

            if (numbers.Length == 0 || count == 0)
            {
                return 0;
            }
            return sum / count;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot factorial a negative.");
            }

            int ans = 1;

            for(int i = number; i > 0; i--)
            {
                ans *= i;
            }

            return ans;
        }
    }
}
