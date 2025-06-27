using System;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

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

            #region Implicirt and explicit casting
            #region Ex 1[int - long]
            //implicit casting [safe casting]
            //int x = 100; //4 bytes
            //long y; // 8 bytes
            //y = x; // safe casting
            //Console.WriteLine(y); // 100
            //explicit casting [unsafe casting]
            //long x = 1000;
            //int y = (int)x;
            //Console.WriteLine(y);
            //Arthmetic overflow    
            //checked
            //{
            //    long x = 1000;
            //    int y = (int)x;
            //    unchecked
            //    {
            //        Console.WriteLine(y); 
            //    }
            //    }

            //long x = 1000;
            //if (x > int.MaxValue || x < int.MinValue)
            //{
            //    Console.WriteLine("Overflow: Cannot cast long to int safely.");
            //}
            //else
            //{
            //    int y = (int)x;
            //    Console.WriteLine(y); 
            //}

            //object Num = 1000;
            //if (Num.GetType() == typeof(int))
            //{
            //    int y = (int)Num;
            //    Console.WriteLine(y);
            //}
            //else
            //{
            //    Console.WriteLine("Cannot cast Num to int safely.");
            //}
            #endregion

            #region Ex 2[int - float ]
            //implicit int ==> float
            //int x = 100; // 4 bytes
            //float y=x; //implicit casting
            //Console.WriteLine(y);

            //explicit float ==> int
            //float x = 100.5f; 
            //int y = (int)x; // explicit casting
            //Console.WriteLine(y); // unsafe casting, will lose the decimal part
            #endregion
            #endregion

            #region Casting [Convert - parse - TryParse]
            //Ex :Enter name , Age ,salary
            //Console.WriteLine("Enter your data: ");
            //Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine()); // Convert 
            //Console.WriteLine("Enter your salary:");
            //double salary = Convert.ToDouble(Console.ReadLine()); // Convert
            //Console.Clear ();
            //Console.Beep(5, 120);
            //Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}");



            //Console.WriteLine("Enter your data: ");
            //Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());  
            //Console.WriteLine("Enter your salary:");
            //double salary = double.Parse(Console.ReadLine()); 
            //Console.Clear();
            //Console.Beep(5, 120);
            //Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}");

            //Console.WriteLine("Enter your data: ");
            //Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your age: ");
            //int age;
            //bool isAgeParsed = int.TryParse(Console.ReadLine(),out age);
            //Console.WriteLine("Enter your salary:");
            //double.TryParse(Console.ReadLine(),out double salary);
            //Console.Clear();
            //Console.WriteLine($"Name: {name}, Age: {(isAgeParsed ? age.ToString() : "Invalid Age")}, Salary: {salary}");
            //Console.Beep(5, 120);
            //Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}");
            #endregion

            #region Operators and operators priority
            #region Unary Operators
            //Unary --> works on one variable, one operand
            //int x = 10;
            // 1] ++ ,, x=x+1 ,,x+=1;
            //[ prefix : increment then print , postfix : print then increment ]
            //Console.WriteLine("initial Value: " + x);// 10
            //Console.WriteLine(  "++x: " + ++x); // 11
            //Console.WriteLine("x++:" + X++); // 11
            //Console.WriteLine("final Value: " + x); // 12

            // 2] [ prefix : Decrement then print , postfix : print then decrement ]
            // int Y = 10;
            //Console.WriteLine("initial Value: " + y);// 10
            //Console.WriteLine(  "--y: " + --y); // 9
            //Console.WriteLine("y--:" + y--); // 9
            //Console.WriteLine("final Value: " + y); // 8
            #endregion
            #region Binary /Arthmetic Operators
            //Binary --> works on two variables, two operands
            int a= 10, b = 5;
            Console.WriteLine("Addition: " + (a + b)); // 15
            Console.WriteLine("Subtraction: " + (a - b)); // 5
            Console.WriteLine("Multiplication: " + (a * b)); // 50
            Console.WriteLine("Division: " + (a / b)); // 2
            Console.WriteLine("Modulus: " + (a % 3)); // 1
                                                      //even or odd
                                                      //even 2, odd 1
            #endregion
            #region Assignment operators
            // int a = 10;
            // //1. simple assignment
            // a = 10;
            // Console.WriteLine("Simple Assignment: " + a); // 10
            // //2. Add and assign
            ////A+= 5; // a = a + 5
            //Console.WriteLine("Add and Assign: " + (a += 5)); // 15
            // //3. Subtract and assign
            // a -= 3; // a = a - 3
            // Console.WriteLine("Subtract and Assign: " + a); // 12
            // //4. Multiply and assign
            // a *= 2; // a = a * 2
            // Console.WriteLine("Multiply and Assign: " + a); // 24
            // //5. Divide and assign
            // a /= 4; // a = a / 4
            // Console.WriteLine("Divide and Assign: " + a); // 6
            // //6. Modulus and assign
            // a %= 5; // a = a % 5
            // Console.WriteLine("Modulus and Assign: " + a); // 1


            #endregion
            #region Relational Operators [Comparison Operators]
            //return bool [true or false]
            //int a = 10, b = 5;
            //equal to(==)
            //Console.WriteLine("a==b : " + (a == b)); // false
            //not equal to(!=)
            //Console.WriteLine("a!=b : " + (a != b)); // true
            //greater than(>)
            //Console.WriteLine("a>b : " + (a > b)); // true
            //less than(<)
            //Console.WriteLine("a<b : " + (a < b)); // false
            //greater than or equal to(>=)
            //Console.WriteLine("a>=b : " + (a >= b)); // true
            //less than or equal to(<=)
            //Console.WriteLine("a<=b : " + (a <= b)); // false

            #endregion
            #region Logical Operators
            //short-circuiting
            bool A = true, B = false;
            //logical not (!)
            Console.WriteLine("!A: " + !A); // false
            Console.WriteLine("!B: " + !B); // true
            //logical and (&&) [short-circuiting]
            //true && true = true
            //true && false = false
            //false && true = false
            //false && false = false
            Console.WriteLine("A && B: " + (A && B)); // false
            //logical or (||) [short-circuiting]
            //true || true = true
            //true || false = true
            //false || true = true
            //false || false = false
            Console.WriteLine("A || B: " + (A || B)); // true
            #endregion
            #region Bitwise Operators
            //int a=5; // 0101 in binary
            //int b=3; // 0011 in binary
            //Bitwise AND (&)
            //true & true = true
            //true & false = false
            //false & true = false
            //false & false = false
            //Console.WriteLine("a & b: " + (a & b)); // 1 (0001 in binary)
            //Bitwise OR (|)
            //true | true = true
            //true | false = true
            //false | true = true
            //false | false = false
            //Console.WriteLine("a | b: " + (a | b)); // 7 (0111 in binary)
            //Bitwise XOR (^)
            //0^1 = 1
            //1^0 = 1
            //1^1 = 0
            //0^0 = 0
            //Console.WriteLine("a ^ b: " + (a ^ b)); // 6 (0110 in binary)
            //Bitwise NOT (~)
            //Console.WriteLine("~a: " + (~a)); // -6 (inverts all bits)
            //left shift (<<)
            //Console.WriteLine("a << 1: " + (a << 1)); // 10 (1010 in binary)
            //right shift (>>)
            //Console.WriteLine("a >> 1: " + (a >> 1)); // 2 (0010 in binary)
            #endregion
            #region Ternary Operator
            //int a =5 ,b=20;
            //string result
            //example:simple comparison
            //if (a > b)
            //result = "a is greater than b";
            //else if (b> a)
            //result = "b is greater than a";
            //else
            //result = "a is equal to b";

            //result = (a>b) ? "a is greater" :"b is greater";//if-else
            //result = (a > b) ? "a is greater" : (b > a) ? "b is greater" : "a is equal to b"; // nested ternary


            #endregion
            #region operators priority
            //int a = 10, b = 20,c =30;
            //int equation1 = a - b * c;
            //int equation2 = (a+b) /c;
            //int equation3 = a + b * c / a;
            //int equation4 = (a+b)% c;
            //int equation5 = a + b++;
            //int equation6 = a + ++b;
            //int equation7 = a+b+++c++;


            #endregion
            #endregion

            #region String formatting
            //String Interpolation
            //Equation: 10+5=15
            //int x = 10, y = 5,result = x + y;
            //ring msg= $"Equation: {x} + {y} = {result}";
            //Console.WriteLine(msg); // Equation: 10 + 5 = 15
            //Console.WriteLine($"Equation : {x} + {y} = {result}");
            //Console.WriteLine(15);
            //Console.WriteLine(true);
            //Console.WriteLine(10.5);

            //Format function
            //string msg = string.Format("Equation: {0} + {1} = {2}", x, y, result);
            //Console.WriteLine(msg);
            //composite formatting
            //int x = 10, y = 5, result = x + y;
            //console.WriteLine("Equation: {0} + {1} = {2}", x, y, result);
            //string concatenation
            //int x = 10, y = 5, result = x + y;
            //string msg = "Equation: " + x + " + " + y + " = " + result;
            //Equation
            //Equation :
            //Equation : 10 
            //Equation : 10 + 
            //Equation : 10 + 5
            //Equation : 10 + 5 =
            //Equation : 10 + 5 = 15

            //Console.WriteLine("Equation : " + x + " + " + y + " = " + result);
            //D:\back c# rout\Template (2)\Template\AssignmentOneC#Solution
            //String filepath="D:\\back c# rout\\Template (2)\\Template\\AssignmentOneC#Solution";
            //Console.writeline(filepath);
            //String filepath = @"D:\back c# rout\Template (2)\Template\AssignmentOneC#Solution";
            //Console.WriteLine(filepath);
            //string msg = "Mohamed \t Behairy";
            //Console.WriteLine(msg)
            #endregion

            #region conditional statements
            #region Example 1 [Quarter]
            #region If else
            //Console.WriteLine("enter a month number (1-12): ");
            //int monthNo;
            //bool flag = int.TryParse(Console.ReadLine(), out monthNo);

            //if (monthNo==1)
            //    Console.WriteLine("January");
            //else if (monthNo == 2)
            //     Console.WriteLine("February");
            //else if (monthNo == 3)
            //     Console.WriteLine("March");
            //else
            //    Console.WriteLine("Invalid month number");
            #endregion
            #region Switch
            Console.WriteLine("enter a month number (1-12): ");
            int monthNo;
            bool flag = int.TryParse(Console.ReadLine(), out monthNo);

            switch (monthNo)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }

            //Jump [int , constant pattern]
            //jump table / branch table [data structure] will be generated by the compiler
            //better in the performance than if-else
            //must the case be unique
            //will not create here because num of cases is little

            //jump table:
            //[0] -> address of case 1
            //[1] -> address of case 2
            //[2] -> address of case 3
            #endregion
            #endregion
            #endregion
        }
    }
}
