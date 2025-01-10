using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    // concrete class : fully Implemented
    internal class Rectangley : Shape /* Implement And Inherit From  Shape*/
    {
        public override double Perimeter
        {
            get
            {
                return (Dim01 * Dim02) * 2;
            }
        }
        public override double GetArea()
        {
                return Dim01 * Dim02;
        }
    }
}
