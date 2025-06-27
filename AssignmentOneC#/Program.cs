using System;

namespace AssignmentOne
{
    class Person
    {
        public string Name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 
            /*
             * Ask user for salary amount and print:    
             * "No tax" if < 5000 , and the salary stays the same.
             * "10% tax" if between 5000–9999 ,  subtract 10% tax.
             * "20% tax" if ≥ 10000 ,  subtract 20% tax.
             * Expected output : 
             * ==> 10% tax applied  
             * ==> Final salary after tax 
             */

            //Console.Write("Enter your salary amount: ");
            //double salary = Convert.ToDouble(Console.ReadLine());
            //double finalSalary = salary;

            //if (salary < 5000)
            //{
            //    Console.WriteLine("No tax");
            //    Console.WriteLine("==> Final salary after tax: " + finalSalary);
            //}
            //else if (salary >= 5000 && salary <= 9999)
            //{
            //    double tax = salary * 0.10;
            //    finalSalary = salary - tax;
            //    Console.WriteLine("==> 10% tax applied");
            //    Console.WriteLine("==> Final salary after tax: " + finalSalary);
            //}
            //else
            //{
            //    double tax = salary * 0.20;
            //    finalSalary = salary - tax;
            //    Console.WriteLine("==> 20% tax applied");
            //    Console.WriteLine("==> Final salary after tax: " + finalSalary);
            //}
            #endregion

            #region 1-	Write a program that allows the user to enter a number then print it.
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();
            //Console.WriteLine("You entered: " + input);
            #endregion

            #region 2-	Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 

            //string input = "123abc";

            //try
            //{
            //    int number = Convert.ToInt32(input); 
            //    Console.WriteLine("Converted number: " + number);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("FormatException: The string contains non-numeric characters and cannot be converted to an integer.");
            //}
            #endregion

            #region 3 -    Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //double num1 = 10.5;
            //double num2 = 3.2;
            //double result = num1 / num2;

            //Console.WriteLine("Result of division: " + result);

            #endregion

            #region 4-	Write C# program that Extract a substring from a given string.
            //string fullText = "Hello, World!";

            //string extracted = fullText.Substring(7, 5); 

            //Console.WriteLine("Original string: " + fullText);
            //Console.WriteLine("Extracted substring: " + extracted);
            #endregion

            #region 5-     Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int a = 10;
            //int b = a; 
            //b = 20;

            //Console.WriteLine("Value of a: " + a);
            //Console.WriteLine("Value of b: " + b);

            #endregion

            #region 6-	 Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //Person person1 = new Person();
            //person1.Name = "Ali";

            //Person person2 = person1; 

            //person2.Name = "Omar"; 

            //Console.WriteLine("person1.Name: " + person1.Name);
            //Console.WriteLine("person2.Name: " + person2.Name);
            #endregion

            #region 7-	Write C# program that take two string variables and print them as one variable 
            //string firstName = "Mohamed";
            //string lastName = "Behiry";

            //string fullName = firstName + " " + lastName;

            //Console.WriteLine("Full name: " + fullName);

            #endregion

            #region 8-	Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.
            //Console.Write("Enter the principal amount: ");
            //double principal = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the rate of interest: ");
            //double rate = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the time (in years): ");
            //double time = Convert.ToDouble(Console.ReadLine());

            //double interest = (principal * rate * time) / 100;

            //Console.WriteLine("Simple Interest = " + interest);

            #endregion

            #region 9-	Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)

            //Console.Write("Enter weight in kilograms: ");
            //double weight = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter height in meters: ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //double bmi = weight / (height * height);

            //Console.WriteLine("Your BMI is: " + bmi);
            #endregion

            #region 10-	Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex:
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001

            //Console.Write("Enter day: ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter month: ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter year: ");
            //int year = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Today's date : {day} , {month} , {year}");
            //Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //Console.WriteLine($"Today's date : {day} – {month} – {year}");
            #endregion

            #region 11-	 What is the output of the following C# code?
            /*  
             DateTime date = new DateTime(2024, 6, 14);
             Console.WriteLine($"The event is on {date:MM/dd/yyyy}");*/

            //The event is on 06/14/2024

            #endregion

            #region 12-	Which of the following statements is correct about the C#.NET code snippet given below?
            /*
             * int d; 
             * d = Convert.ToInt32( !(30 < 20) );
             */
            #endregion

            #region 13-	Which of the following is the correct output for the C# code given below?
            /*Console.WriteLine(13 / 2 + " " + 13 % 2); */

            #endregion
        }
    }
}
