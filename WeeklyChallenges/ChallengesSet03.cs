using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace WeeklyChallenges
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
                

            }
            return false;
           
            //1.What do they give us ? a collection of integers
            //-array of bools
            //2.What are we returning ? bool true or false
            //-a bool(true or false)
            //3.What do we need to do? find odd numbers and figure out if sum is odd
            //-want to see if the array contains a false value


        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) 
            {
                return false;
            }
            
            var sumOdd = 0;
            foreach (var item in numbers)
            {
                if (item % 2 != 0)
                {
                    sumOdd += item;
                }
            }
            if (sumOdd % 2 != 0)
            {
                return true;
            }
            else return false;
        }


        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
                {
                    return true;
                }
                
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            int indexNum = ((val.Length) - 1);
            return val[indexNum];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0 || dividend == 0)
            {
                return 0;
            }
            else
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            

            int x = nums.Length;
            int first = nums[0];
            int last = nums[x - 1];

            return last - first;
        }

        public int[] GetOddsBelow100()
        {

            //throw new NotImplementedException();
            int[] array = new int[50];
            int j = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    array[j] = i;
                    j++;
                }
                
            }
            return array;

            

            


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
