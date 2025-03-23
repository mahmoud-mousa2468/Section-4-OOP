using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    internal class TypeB:TypeA
    {
        public int B { get; set; }
        public sealed override int A { get => base.A; set => base.A = value; }
        public sealed override void MyFun()
        {
            base.MyFun();
        }
    }
}
