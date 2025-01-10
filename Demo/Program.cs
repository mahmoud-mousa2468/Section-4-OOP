using System.Drawing;
using Demo.Abstraction;

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

            Rectangley rectangle = new Rectangley()
            {
                Dim01 = 12,
                Dim02 = 3
            };
            Console.WriteLine(rectangle.Perimeter);
            Console.WriteLine(rectangle.GetArea());
            #endregion
        }
    }
}
