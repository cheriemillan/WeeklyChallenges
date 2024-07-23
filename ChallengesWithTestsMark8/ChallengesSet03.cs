using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {

            if (vals == null || vals.Length == 0)
            {
                return false;
            }

            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            return numbers.Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool digit = false;
            bool upper = false;
            bool lower = false;

            foreach (char p in password)
            {

                if (char.IsUpper(p))
                {
                    upper = true;
                }
                else if (char.IsDigit(p))
                {
                    digit = true;
                }
                else if (char.IsLower(p))
                {
                    lower = true;
                }

            }

            if (digit && upper && lower)
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
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
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
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            int[] num = new int[50];
            int start = 0;
            
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    num[start] = i;
                    start++;
                }
            }

            return num;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
        


