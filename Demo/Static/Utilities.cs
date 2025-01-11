using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    // static [Helper]
    internal static class Utilities
    {
        private static double pi;
        static Utilities()
        {
            pi = 3.14;
        }

        // static methood : class member method

        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }
        public static double PI
        {
            get
            {
                return pi;
            }
        }

    }
}
