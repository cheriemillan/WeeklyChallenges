using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    
                } else {
                    sum -= num;
                }
            }

            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] lengths = new int[]
            {
                str1?.Length ?? 0,
                str2?.Length ?? 0,
                str3?.Length ?? 0,
                str4?.Length ?? 0,
            };

            int minLength = lengths[0];

            for (int i = 1; i < lengths.Length; i++)
            {
                if (lengths[i] < minLength)
                {
                    minLength = lengths[i];
                }
            }

            return minLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = new int[] { number1, number2, number3, number4 };

            int minNum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minNum)
                {
                    minNum = numbers[i];
                }
            }

            return minNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if(biz != null)
            {
                biz.Name = "TrueCoders";
            }
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {

            if (sideLength1 <= 0 && sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }
            return ( sideLength1 + sideLength2 > sideLength3) && (sideLength1 + sideLength3 > sideLength2) && (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            double result;
            return double.TryParse(input, out result);

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0)
            {
                return false;
            }

            int count = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }

            return count > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
                if (numbers == null || numbers.Length == 0)
                {

                    return 0;
                }

                int sum = 0;
                int count = 0;
                
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        sum += num;
                        count++;
                    }
                }

                if (count == 0)
                {
                    return 0;
                }

                return (double)sum / count;

        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
