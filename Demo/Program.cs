using System;
using System.Drawing;
using System.Globalization;

namespace Demo
{
    internal class Program
    {
        
        static void print<T>(T value)
        {
            Console.WriteLine(value);
        }

        
        static void TestPrint()
        {
            print(10);
            print<int>(10);
            print("Mariam");
            print(true);
        }

        
        static void PrintObj(object Obj)
        {
            Console.WriteLine(Obj);
        }

        
        static void TestPrintObj()
        {
            PrintObj(10); // Boxing
            PrintObj("Mariam");
            PrintObj(10.5);
        }

        
        static void Main(string[] args)
        {
            #region Object
            #region Intro
            // Object obj;
            // obj = 100;
            // obj = "100";
            // obj = "Mariam";
            //int result = 10 + (int)obj; // runtime error if obj is string
            #endregion
            #region ToString
            //Point P1 = new Point() { X = 1, Y = 2 };
            //Console.WriteLine(P1.ToString()); // sessionThree.Point
            //int x = 1234;
            //Console.WriteLine(x.ToString()); // 1234
            //object Num = 1234;
            ////Console.WriteLine(Num.ToString());
            ////call ToString object
            ////call back ToString Int32
            //object Name = "Mariam";
            ////Console.WriteLIne(Name.ToString);
            #endregion
            #region Equals
            //Point P1 = new Point() { X = 1, Y = 2 };
            //Point p2 = new Point() { X = 1, Y = 2 };
            //P1= p2; 
            //Console.WriteLine(P1.Equals(p2)); // True
            //int x = 1234;
            //int y = 1234;
            //Console.WriteLine(x.Equals(y)); // True
            //object Num = 1234;
            //object Num2 = 1234;
            //Console.WriteLine(Num.Equals(Num2)); // False
            //String n="mariam", n2="mariam";
            //object Name = "Mariam";
            //object Name2 = "Mariam";
            //Console.WriteLine(Name.Equals(Name2)); // True
            #endregion
            #region GetHashCode
            //Point P1 = new Point() { X = 1, Y = 2 };
            //Point p2 = new Point() { X = 1, Y = 2 };
            //P1= p2; 
            //Console.WriteLine(P1.GetHashCode()); // Hash code of P1
            //Console.WriteLine(p2.GetHashCode()); // Hash code of p2
            //int x = 1234;
            //int y = 1234;
            //Console.WriteLine(x.GetHashCode()); // Hash code of x
            //Console.WriteLine(y.GetHashCode()); // Hash code of y
            //object Num = 1234;
            //Console.WriteLine(Num.GetHashCode()); // Hash code of Num

            //String n = "mariam", n2 = "mariam";
            //object Name = "Mariam";
            //object Name2 = "Mariam";
            //Console.WriteLine(Name.GetHashCode()); // Hash code of Name
            //Console.WriteLine(Name2.GetHashCode()); // Hash code of Name2


            #endregion
            #region GetType
            //Point P1 = new Point() { X = 1, Y = 2 }
            //Console.WriteLine(P1.GetType()); // sessionThree.Point

            //int x = 1234;
            //Console.WriteLine(x.GetType()); // System.Int32
            //object Num = 1234;
            //Console.WriteLine(Num.GetType()); // System.Int32   

            //object Name = "Mariam";
            //Console.WriteLine(Name.GetType()); // System.String

            #endregion
            #region Exmple
            object obj = new object();
            //reference refer null
            //refer any instance of object or any data type that inherit from object
            obj = 100; // boxing
            obj = "Mariam";
            obj = 100.5;
            double s = (double)obj; // unboxing
            #endregion

            #endregion


            #region Fraction & Discard
            //12.3425865224484488484841
            //float number = 12.34258f;
            //Console.WriteLine(number); // 12.34258
            //float number2 = 10;
            //Console.WriteLine(number2); // 10

            //decimal number = 12.34258m;
            //Console.WriteLine(number); 
            //decimal number2 = 10;
            //Console.WriteLine(number2);

            //float result = 3.0f / 2;
            //Console.WriteLine(result); // 1.5

            //double number = 12.3456;
            //Console.WriteLine(number); // 12.3456

            //Discard , Digit Separator[]
            //int number3 = 1_000_000; // 1 million
            //Console.WriteLine(number3); // 1000000
            //int.TryParse(Console.ReadLine(), out _);

            //int number4 = 1_000_000;
            ////Console.WriteLine(number4); // 1000000
            //Console.WriteLine($"{number4:c}");

            //CultureInfo cultureInfo = new CultureInfo("ar-SA");
            //Console.WriteLine(number.ToString("C", cultureInfo)); // ١٢٫٣٤٢٥٨ ر.س.
            #endregion

        }
    }
}
