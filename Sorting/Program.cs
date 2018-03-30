using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    class Program
    {
        // needed to bring in a module for lists:
        //public static List<int> arr = new List<int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = SayHi("hee");
            Console.WriteLine(str);
            int[] input = new int[] { 3, 4, 1, 2, 5, 2, 3, 2, 8, 2, 0, 5 };
            int[] result = CountSort(input);
            Console.WriteLine(result);
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }

        static String SayHi(string args)
        {
            Console.WriteLine(args);
            return "hi";
        }

        // takes in array of integers, returns a list of integers:
        static int[] CountSort(int[] args)
        {
            //Console.WriteLine(args);
            // Ok so it was "public static" that was throwing it off....maybe you only say those in a class, not in a method?
            //List<int> res = new List<int>();

            // Playing around to learn the syntax:
            //for (int i = 0; i < args.Length; i++)
            //{
            //    result[i] = args[i];
            //}

            // Different syntax:
            //foreach(int i in args)
            //{
            //    res.Add(i);
            //}


            // actually we want an array result, because we know its length:
            int[] result = new int[args.Length + 1];

            // needed to bring in another module for this:
            int max = args.Max();
            //Console.WriteLine(args.Max());

            // Initialize counting array:
            int[] counting_array = new int[max + 1];

            // Populate counting array:
            foreach(int el in args)
            {
                counting_array[el]++;
            }

            // Modify counting array:
            for (int i = 1; i < counting_array.Length; i++)
            {
                counting_array[i] += counting_array[i - 1];
            }

            // Final step, populate result:
            for (int i = args.Length - 1; i >= 0; i--)
            {
                int val = counting_array[args[i]];
                result[val] = args[i];
                counting_array[args[i]]--;
            }

        
            return result;
            //return new List<int>();
        }
    }
}
