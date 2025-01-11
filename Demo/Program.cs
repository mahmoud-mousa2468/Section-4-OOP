using System.Drawing;
using System.Numerics;
using Demo.Abstraction;
using Demo.operatorOverloading;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction
            // abstract : C# keyword [class - methods - properties]
            // abstract class 
            // abstract method 
            // abstract property 


            //2D Shape

            // Shape shape = new Shape();
            // Note : Can't Create object from Abstrat class

            // shape.GetArea;

            //Rectangley rectangle = new Rectangley()
            //{
            //    Dim01 = 12,
            //    Dim02 = 3
            //};
            //Console.WriteLine(rectangle.Perimeter);
            //Console.WriteLine(rectangle.GetArea());
            #endregion
            #region Operator Overloading
            //int x=3+4;
            //string y = "Hello" + "World";
            // Complex Number : Real +Imag

            // 4 + 3 i
            // 4 + 3 ت

            MyComplex C01 = new MyComplex()
            {
                Real=3,Imag=4
            };
            MyComplex C02 = new MyComplex()
            {
                Real=5,Imag=6
            };
            MyComplex C03 = C01 + null;
            Console.WriteLine(C03);
            #endregion
        }
    }
}
