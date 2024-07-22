using System;
using System.Diagnostics;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double sub = minuend - subtrahend;
            return sub;
        }

        public int Add(int number1, int number2)
        {
            int add = number1 + number2;
            return add;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number2;
            }
            else
            {
                return number1;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            long mult = factor1 * factor2;
            return mult;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (string.IsNullOrEmpty(nameOfPerson))
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!"; 
            }

        }

        public string GetHey()
        {
            string hey = "HEY!";
            return hey;

        }
    }
}
