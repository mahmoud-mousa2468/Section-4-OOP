using System.Drawing;
using System.Numerics;
using Demo.Abstraction;
using Demo.Mapping;
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

            //MyComplex C01 = new MyComplex()
            //{
            //    Real = 3,
            //    Imag = 4
            //};
            //MyComplex C02 = new MyComplex()
            //{
            //    Real = 5,
            //    Imag = 6
            //};
            //MyComplex C03 = C01 + null;
            //Console.WriteLine(C03);

            //Console.WriteLine(++C01);

            //if (C01 > C02)
            //{
            //    Console.WriteLine("C01 is greater than C02");
            //}
            //else
            //{
            //    Console.WriteLine("C01 is not greater than C02");

            //}
            #endregion

            #region UserDefined Casting Operator

            // double X=12;

            //int Y=(int)X;

            // (int) : Casting Operator

            MyComplex C01 = new MyComplex()
            {
                Real = 3,
                Imag = 4
            };
            string S = (string)C01;
            // (string) : Convert Complex Number To String

            /// Operator Overloading
            /// user-Defiend Casting Operator
            /// 

            //Console.WriteLine(S);
            //int X = (int)C01;
            //Console.WriteLine(X);

            int X =(int) new MyComplex() { Real = 10, Imag = 20 };


            // Mapping :convert from Datatype To Datatype

            // code first
            // DB First

            // User [Id,Name,Email,UserName,PhoneNum,CardNum,ExipreDate]
            // UserViewModel
            // USerDto
            // [Name,Email,PhoneNum]

            // Mannual Mapping

            User user = new User();
            UserDto userDto = new UserDto()
            {
                Email = user.Email,
                Name = user.Name,
                PhoneNum = user.PhoneNum
            };

            // Casting Operator

            // Automapper : Mapping Automatic

            #endregion

        }
    }
}
