using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class Operators
    {
        [TestMethod]
        static void TMain(string[] args)
        {
            int numOne = 7;
            int numTwo = 20;

            //Addition
            int sum = numOne + numTwo;
            Console.WriteLine(sum);

            //Subtraction
            int difference = numTwo - numOne;
            Console.WriteLine(difference);

            //Multiplication
            int product = numOne * numTwo;
            Console.WriteLine(product);

            //Division
            int quotient = numOne / numTwo;
            Console.WriteLine(quotient);

            //Remainder
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            //TimeSpan
            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(1997, 5, 6);
            TimeSpan timeSpan = today - someDay;
            Console.WriteLine(timeSpan);

            //Conversions
            //Casting - attempts to change objects to that of another type
            //type name = (castType)value;
            int five = 5;
            double doubleFive = double(five);
            Console.WriteLine(doubleFive);

            char a = 'a';
            int valueA = (int)a;
            Console.WriteLine(valueA);
            Console.WriteLine(a);

            //string = myString = "This is a string.";
            //byte myByte = (byte)myString;

            //Conversion
            //type = Convert.ToType(value);

            int intFive = 5;
            decimal decimalFive = Convert.ToDecimal(intFive);

            //Parsing -strings only
            //type name = type.parse(string);
            string decimalString = "5.6987";
            decimal decimalValue = decimal.Parse(decimalString);
            
            
            
            //Comparison Operators
            Console.WriteLine("Enter your age.");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            Console.WriteLine("Enter in your name.");
            string userName = Console.ReadLine();
            bool 






            Console.ReadKey();
        }
    }
}
