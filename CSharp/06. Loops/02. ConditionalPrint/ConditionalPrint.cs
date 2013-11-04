﻿/* Write a program that prints all the numbers from 1 to N, 
 * that are not divisible by 3 and 7 at the same time.
 */

using System;

class ConditionalPrint
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            if (i % 21 != 0)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}