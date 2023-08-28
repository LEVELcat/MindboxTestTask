using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestTask
{
    public abstract class Shape
    {
        protected Shape()
        {
        }

        public abstract double AreaOfShape { get; }

        public static double MinimalValue { get; } = 1.0E-10;
        public static double MaximalValue { get; } = 1.0E+20;

        protected virtual bool CheckValueIsInRange(double value) => 
                                                          value >= MinimalValue && value <= MaximalValue;
    }
}
