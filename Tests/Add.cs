using System;
using System.Collections.Generic;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = AddNumbers(5, 10);
            Console.WriteLine("Result: " + result);

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

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static void DoNothing()
        {
