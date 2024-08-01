using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PracticeExcercises
{
    public class PracticeExcercises
    {
        private static readonly string applicationName = "Practice problems 1";
        private static bool exit = false;

        static void Main(string[] args)
        {

            Console.WriteLine(applicationName); //Print application name on first line
            Console.WriteLine(new String('-', applicationName.Length)); //Print dashes under name
            Console.WriteLine('\n');

            while (!exit)
            {
                //print choices
                MenuChoices();
            }

        }

        private static void MenuChoices()
        {
            //Menu Options
            Console.WriteLine("1. Print Operations.");
            Console.WriteLine("2. Basic Calculator.");
            Console.WriteLine("3. Calculate perimeter and area");
            Console.WriteLine("4. Calculate If True");
            Console.WriteLine("5. Basic Cube Calculator");
            Console.WriteLine("6. Exit");
            Console.WriteLine("\n");
            Console.Write("Input Choice from menu: ");

            string choiceInput = Console.ReadLine();
            int choice = int.Parse(choiceInput);

            //write switch statement to loop through each menu option

            switch (choice)
            {
                case 1:
                    SpecifiedOperations();
                    break;
                case 2:
                    SimpleCalculator();
                    break;
                case 3:
                    SimpleCircleCalculator();
                    break;
                case 4:
                    SimpleBoolCalculator();
                    break;
                case 5:
                    SimpleCubeCalculator();
                    break;
                case 6:
                    Exit();
                    break;
                default:
                    break;
            }
        }

        private static void SpecifiedOperations()
        {
            // 1. Write a C# Sharp program to print the results of the specified operations:

            Console.WriteLine("(1.) -1 + 4 * 6\r\n\n" +
                              "(2.) (35 + 5 ) % 7\r\n\n" +
                              "(3.) 14 + -4 * 6 / 11\r\n\n" +
                              "(4.) 2 + 15 / 6 * 1 - 7 % 2\n");

            int a = -1 + 4 * 6;
            int b = (35 + 5) % 7;
            int c = 14 + -4 * 6 / 11;
            int d = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine($"1.{a}, 2.{b}, 3.{c}, 4.{d}\n");
        }

        private static void SimpleCalculator()
        {
            //2.Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that operation.

            //Example
            //Input first number: 20
            //Input operation: -
            //Input second number: 12
            //Expected Output :
            //20 - 12 = 8
        }

        private static void SimpleCircleCalculator()
        {
            //3.Write a C# Sharp program that takes the radius of a circle as input and calculates the perimeter and area of the circle.
        }

        private static void SimpleBoolCalculator()
        {
            //4.Write a C# Sharp program to accept two integers and check whether they are equal or not.
        }

        private static void SimpleCubeCalculator()
        {
            //5. Write a C# Sharp program to display the cube of an integer up to given number.
            //Test Data :
            //Input number of terms : 5
            //Expected Output :
            //Number is : 1 and cube of the 1 is :1
            //Number is : 2 and cube of the 2 is :8
            //Number is : 3 and cube of the 3 is :27
            //Number is : 4 and cube of the 4 is :64
            //Number is : 5 and cube of the 5 is :125
        }

        private static void Exit()
        {
            exit = true;//if true program exits
        }


    }
}
