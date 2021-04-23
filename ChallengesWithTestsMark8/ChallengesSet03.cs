using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < vals.Length; i++)
                {
                    if (vals[i] == false)
                    {
                        return true;
                    }
                }
            }
            return false;
            //throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else
            {
                int odd = 0;
                foreach ( var i in numbers)
                {
                    if (i % 2 != 0)
                    {
                        odd += i;
                    }
                }
                
                if (odd % 2 != 0) // return odd % 2 != 0 ? true : false;
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            
            char[] charArray = password.ToCharArray();
            int lower = 0;
            int upper = 0;
            int digits = 0;
            bool status = true;

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLower(charArray[i]))
                    lower++;
                if (char.IsUpper(charArray[i]))
                    upper++;
                if (char.IsDigit(charArray[i]))
                    digits++;
            }

            return (lower > 0 && upper > 0 && digits > 0) ? true : false;
            
        }

        public char GetFirstLetterOfString(string val)
        {
            return Convert.ToChar(val.Substring(0, 1));
        }

        public char GetLastLetterOfString(string val)
        {
            return Convert.ToChar(val.Substring(val.Length - 1, 1));
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            int first = (int)nums.GetValue(0);
            int last = (int)nums.GetValue(nums.Length - 1);
            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            int[] actual = new int[50];
            for (int i = 0; i < actual.Length; i++)
            {
                actual[i] = 2 * i + 1;
                
            }
            return actual;


        }


        public void ChangeAllElementsToUppercase(string[] words)
        {
            int i = 0;
            foreach (var word in words)
            {
                words[i] = words[i].ToUpper();
                //Console.Write(" {0}", words[i]);
                i++;
            }
            //for (int i = 0; i < words.Length; i++)
            //{
            //    words[i] = words[i].ToUpper();
            //}
        }
    }
}
