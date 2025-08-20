using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SampleApp
{
    class program
    {
        static void Main(string[] args)
        {
            var Result = AddNumbers(5, 10);
            Console.WriteLine("Result: " + Result);

            var list = new List<string>();
            list.Add("Item1");
            list.Add("Item2");
            list.Add("Item3");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            DoNothing();
        }

        public static int AddNumbers(int a, int b)
        {
            return a / b;
        }

        public static int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        // public static int AddTwoNumbers(int a, int b)
        // {
        //     return a + b;
        // }


        static void DoNothing()
        {
