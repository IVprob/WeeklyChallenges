using System;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");


            //int[] array = new int[50];
            //{ 
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        array[i] = 2 * i + 1;
            //        Console.WriteLine(array[i]);
            //    }
            //}

            string[] words = { "this", "is", "it" };
            //for (int i = 0; i < words.Length; i++)
            //{
            //    words[i] = words[i].ToUpper();


            //    Console.WriteLine(words[i]);

            //}

            int i = 0;
            foreach (var word in words)
            {
                words[i] = words[i].ToUpper();
                    Console.Write(" {0}", words[i]);
                i++;
                }

        }   
    }
}
