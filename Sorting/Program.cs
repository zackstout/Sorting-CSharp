using System;
using System.Collections.Generic;

namespace Sorting
{
    class Program
    {
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
            // actually we want an array result, because we know its length:
            int[] result = new int[args.Length];


            for (int i = 0; i < args.Length; i++)
            {
                result[i] = args[i];
            }
            //foreach(int i in args)
            //{
            //    res.Add(i);
            //}
        
            return result;
            //return new List<int>();
        }
    }
}
