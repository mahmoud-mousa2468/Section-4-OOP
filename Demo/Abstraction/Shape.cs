using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    // Abstract Class : Partial Class [Not Fully Implemented Class]
    // Concert Class  : Fully Implemented Class
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        // Abstract Method : like Virtual Method Without Implementation
        public abstract double GetArea();
        // Abstract Method : like Virtual Property Without Implementation

        {
        }
    }
}
