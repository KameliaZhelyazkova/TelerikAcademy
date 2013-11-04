﻿namespace FigureRotator
{
    using System;

    public class Program
    {
        public static Figure GetRotatedFigure(Figure shape, double rotatingAngle)
        {
            double cosOfAngle = Math.Cos(rotatingAngle);
            double sinOfAngle = Math.Sin(rotatingAngle);

            return new Figure(
              (Math.Abs(cosOfAngle) * shape.Width) + (Math.Abs(sinOfAngle) * shape.Height),
              (Math.Abs(sinOfAngle) * shape.Width) + (Math.Abs(cosOfAngle) * shape.Height));
        }

        public static void Main()
        {
            Figure testFigure = GetRotatedFigure(new Figure(2,2),20);
            Console.WriteLine(testFigure.Height);
        }
    }
}
