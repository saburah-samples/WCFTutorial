// -----------------------------------------------------------------------
// <copyright file="SimpleCalculator.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace MyCalcSvc
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class SimpleCalculator: ISimpleCalculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
