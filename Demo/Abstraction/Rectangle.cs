using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    // concrete class fully Implemented
    internal class Rectangle : Shape /* Implement And Inherit From  Shape*/
    {
        public override double Perimeter
        {
            get
            {
                return Dim01 * Dim02;
            }
        }
        public override double GetArea()
        {
            return Dim01 * Dim02;
        }
    }
}
