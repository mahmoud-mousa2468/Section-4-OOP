using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        // Abstract Method : like Virtual Method Without Implementation
        public abstract double GetArea();

        public abstract double Perimeter
        {
            get;
        }
    }
}
