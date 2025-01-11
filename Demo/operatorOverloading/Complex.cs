using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Demo.operatorOverloading
{
    internal class MyComplex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        //Operator Overloading
        // Must be Puplic & Static
        // Binary Operator + - / * %
        public static MyComplex operator +(MyComplex left, MyComplex right)
        {
            return new MyComplex()
            {
                Real=(left?.Real ?? 0)+(right?.Real ?? 0),
                Imag=(left?.Imag ?? 0)+(right?.Imag ?? 0)
            };
        }
        public static MyComplex operator -(MyComplex left, MyComplex right)
        {
            return new MyComplex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0)
            };
        }
        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }
    }
}
