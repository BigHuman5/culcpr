﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{
    public class Negatively :IoneArgument
    {
        /// <summary>
        /// this method reverse argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            double result = 0-FirstElement;
            return result;
        }
    }
}