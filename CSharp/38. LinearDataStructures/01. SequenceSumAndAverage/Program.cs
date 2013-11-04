﻿namespace SequenceSumAndAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> inputNumbers = new List<int>();
            bool isEndCommand = false;

            while (!isEndCommand)
            {
                string inputLine = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputLine))
                {
                    isEndCommand = true;
                }
                else
                {
                    int parsedNumber = int.MinValue;
                    if (int.TryParse(inputLine, out parsedNumber) && parsedNumber > 0)
                    {
                        inputNumbers.Add(parsedNumber);
                    }
                    else
                    {
                        Console.WriteLine("Ivalid number format! Try again!");
                    }
                }
            }

            Console.WriteLine("The sum of the numbers is {0}", MathUtils.FindSum(inputNumbers));
            Console.WriteLine("The average of the numbers is {0}", MathUtils.FindAverage(inputNumbers));
        }
    }
}
