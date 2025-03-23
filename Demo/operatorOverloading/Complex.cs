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

        //Operator Overloading
        // Must be Puplic & Static
        // Unary Operator ++ --
        public static MyComplex operator ++(MyComplex Com)
        {
            return new MyComplex() 
            { Real=((Com?.Real??0)+1),
              Imag=(Com?.Imag??0)
            };
        }
        public static MyComplex operator --(MyComplex Com)
        {
            return new MyComplex()
            {
                Real = ((Com?.Real ?? 0) - 1),
                Imag = (Com?.Imag ?? 0) 
            };
        }
        //Operator Overloading
        // Must be Puplic & Static
        // Comparsion Operator Binary : > < >= <= == !=
         public static bool operator >(MyComplex left,MyComplex right)
        {
            if (left.Real == right.Real)
                return left.Imag > right.Imag;
            return left.Real > right.Real;
        }
        public static bool operator <(MyComplex left, MyComplex right)
        {
            if (left.Real == right.Real)
                return left.Imag < right.Imag;
            return left.Real < right.Real;
        }
        // >= <= 
        public static bool operator >=(MyComplex left, MyComplex right)
        {
            if (left.Real == right.Real)
                return left.Imag >= right.Imag;
            return left.Real >= right.Real;
        }
        public static bool operator <=(MyComplex left, MyComplex right)
        {
            if (left.Real == right.Real)
                return left.Imag <= right.Imag;
            return left.Real <= right.Real;
        }
        // = !=
        public static bool operator ==(MyComplex left, MyComplex right)
        {
            
            return left.Real == right.Real && left.Imag==right.Imag;
        }
        public static bool operator !=(MyComplex left, MyComplex right)
        {
            return left.Real != right.Real || left.Imag!=right.Imag;

        }

        // User-Defiend Casting Operator
        // Complex ---> String
        // Function : public - static

        // Implicit - Explicit

        public static explicit operator string(MyComplex complex)
        {
            //return $"{complex.Real} + {complex.Imag} i";
            return complex.ToString();
        }

        public static explicit operator int(MyComplex complex)
        {
            return complex.Real + complex.Imag;
        }
        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }
    }
}
