﻿using System;
using Calcpr.Class;

namespace Calcpr
{
    public class TwoArgumentsFactory
    {
        /// <summary>
        /// factory for working with two arguments
        /// </summary>
        /// <param name="sender">It`s name key</param>
        /// <returns></returns>
        public static ITwoArgumentsCalculator CreateCalculator(string sender)
        {
            switch (sender)
            {
                case "Addition":
                    return new Addition();
                case "Division":
                    return new Division();
                case "Multiplication":
                    return new Multiplication();
                case "Subtraction":
                    return new Subtraction();
                case "Average":
                    return new Average();
                case "Remainder":
                    return new Remainder();
                case "fractionation":
                    return new Fractionation();
                case "max":
                    return new Max();
                case "min":
                    return new Min();
                case "geometricMean":
                    return new GeometricMean();
                case "exponentiation":
                    return new Exponentiation();
                case "log":
                    return new Log();
                case "IntegerDivision":
                    return new IntegerDivision();
                default:
                    throw new Exception("Неизвестная ошибка");
            }
        }
    }
}
