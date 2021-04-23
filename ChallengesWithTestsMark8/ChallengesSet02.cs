using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return System.Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers == null || numbers.Count() < 1 ? 0 : numbers.Max() + numbers.Min();
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                foreach (var num in numbers)
                {
                    sum += num;
                }
                return sum;
            }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        sum += num;
                    }
                }
                return sum;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            else
            {
                int sum = 0;
                foreach (var num in numbers)
                {
                    sum += num;
                }
                return sum % 2 != 0 ? true : false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number > 1 ? number / 2 : 0;


           // ----------------------
            //long upperRange = number;
            //long lowerRange = 0;

            //long num = (((upperRange) - (lowerRange + 2)) / 2) + 1;

            //return number > 1 ? num : 0;
            //-----------------------
            //This doesn't work,
            //long num = 0;
            //if (number > 1)
            //{
            //    for (int i = 0; i < number; i++)
            //    {
            //       if (i % 2 != 0)
            //        {
            //            num++;
            //        }
            //        return num;
            //    }
            //    return num;
            //}
            //else
            //{
            //    return 0;
            //}

            //--------------------------

            //long num = 0;
            //var numList = new List<long> { };

            //if (number <= 1)
            //{
            //    return 0;
            //}
            //else if (number > 1 && number < 10001)
            //{
            //    for (var i = 0; i < number; i++)
            //    {
            //        numList.Add(i);
            //    }
            //    foreach (var item in numList)
            //    {
            //        if (item % 2 != 0)
            //        {
            //            num++;
            //        }

            //    }
            //    return num;
            //}
            //else
            //{
            //    return 0;
            //}
        }
    }
}
