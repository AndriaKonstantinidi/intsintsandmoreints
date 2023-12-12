using System;
using System.Linq;
using System.Collections;

namespace ConsoleApp18
{
    class Program
    {
        private static void Main(string[] args)
        {
            //int[] numbers = new int[] { 1, 2, 3,6,7,8,3,19 };

            //List<int> numbersAsList = numbers.ToList();

            //int numbersGreater = 5;

            //var numbersGreaterThan = from number in numbers
            //                         where number > numbersGreater
            //                         select number;
            //foreach (var number in numbersGreaterThan)
            //{
            //    Console.WriteLine(number);
            //}

            //var maxNum = numbersAsList.Max();

            //Console.WriteLine(maxNum);

            //Console.WriteLine("<--------------------->");

            //var minimums = numbersAsList.Min();

            //Console.WriteLine(minimums);

            //Console.WriteLine("<--------------------->");

            //var averageNum = numbersAsList.Average();

            //Console.WriteLine(averageNum);

            //Console.WriteLine("<--------------------->");

            //var numSum = numbersAsList.Sum();

            //Console.WriteLine(numSum);

            //Console.WriteLine("<--------------------->");

            //var numFirst = numbersAsList[0];

            //Console.WriteLine(numFirst);

            //Console.WriteLine("<--------------------->");

            //var numlast = numbersAsList[7];

            //Console.WriteLine(numlast);

            //Console.WriteLine("<--------------------->");

            //List<int> mixman = new List<int> { minimums, maxNum };


            //Console.WriteLine(mixman.Average());

            int[] numbers = new int[] { 1, 2, 3, 4 };

            var numbersGreaterThan = from number in numbers
                                     where number > numbers.Average()
                                     select number;
            foreach (var number in numbersGreaterThan)
            {
                Console.WriteLine(number);
            }
        }
    }
}