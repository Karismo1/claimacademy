using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    public class Week1
    {
        public void Main(string[] args)

            //Official Microsoft
        {
            //Week 1

            //Data Types

            //Intger: Whole Numbers. 32-bit values go up to 2,147,483,647 which is (2^32 / 2) - 1.
            //Max value given by int.MaxValue (32-bit)
            Console.WriteLine($"Max Integer Value: {int.MaxValue}");

            //Min Value given by int.MinValue (32-bit)
            Console.WriteLine($"Min Integer Value: {int.MinValue}");

            // 64-bit Integers can be accessed with Int struct or long
            //Max Int64 size 18,446,744,073,709,551,615


            //Declare without initial assignment
            int num; // All statements must be ended with ;

            //Assignment: Giving a value to the variable

            num = 6;

            // We can also declare and assign a value at once

            int num2 = 8;

            //Floating point types: 

            // Doubles - Floating point numbers, with decimals, with decimals. Range is 
            double dbl = 1.25d;

            //Floats - Decimals. Range: 
            float floatnum = 4.7589f;

            // Decimal type: Range: 
            decimal decimalNum = 8.567M;

            //Booleans: Can only be true or false, used to determine the binary state of somthing. i.e. true/false, on/off, etc.

            bool boolTrue=true;
            bool boolFalse=false;

            // Characters: Single ASCII or UTF-8 value (depending on character set used, these are the most common character sets)
            //More info: 

            char lowerA = 'a';
            char upperA = 'A';

            int lowerAValue = (int)lowerA;
            Console.WriteLine($"Intger value of lower-case a: {lowerAValue}");

            //strings: Arrays of characters

            string helloWorld = "Hello World";

            //convert to character array
            char[] helloWorldCharArray = helloWorld.ToCharArray();

            Console.Write("Enter your name: "); // Console.Write will not create a new line (same as pressing Enter in notepad).

            // We will declare a string  variable called "name" and assign the user input to the string.

            string name = Console.ReadLine(); // This will create the string variable "name" and then await Keyboard input

            // After taking in the user input from the keyboard, We will print back to the  what the user typed

            Console.WriteLine($"Your name is {name}.");
            Console.ReadKey(); // Keep console window open until key is pressed to end program and close console window.
        }
    }
}
