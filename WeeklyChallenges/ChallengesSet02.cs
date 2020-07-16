using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace WeeklyChallenges
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
            {
                return true;
            }
            else return false;
            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var elementCount = vals.Length;
            var result = elementCount % 2;
            if(result == 0)
            {
                return true;
            }
            else return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else return true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            double sum = (numbers.Min() + numbers.Max());
            return sum;

            


        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else return str1.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers is null)
            {
                return 0;
            }
            else 
            {
                var sum = numbers.Sum();
                return sum;
            }

            

            
        }

        public int SumEvens(int[] numbers)
        {
            int sumOfEvens = 0;
            if (numbers == null)
            {
                return 0;
            }
            
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    sumOfEvens += item;
                }
                
                

                
            }

            return sumOfEvens;




           
            


            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            int total = numbers.Sum(x => Convert.ToInt32(x));
                    

            if (total % 2 == 0)
            {
                return false;
            }
            else return true;

            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        { 
            List<long> oddList = new List<long>();
            
            for (long i = number-1; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    oddList.Add(i); 
                }
            }
            return oddList.Count();
            

            
        }
    }
}
