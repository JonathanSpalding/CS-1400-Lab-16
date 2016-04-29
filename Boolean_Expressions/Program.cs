// Author: Jonathan Spalding
// Assignment: Lab 16
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 3/1/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
// -----------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare some constants for saturday and sunday
            const string SAT = "Saturday";
            const string SUN = "Sunday";
            const double FREEZE = 32;
            // declare a variable to hold user's input
            string today;
            double temp;
            // prompt the user to enter a day and get the input
            Console.WriteLine("Please enter a day of the week, e.g. Tuesday: ");
            today = Console.ReadLine();
            // see if it is a work day
            if (today != SUN && today != SAT)
            {
                // its not a workday, display the weekend message
                Console.WriteLine("What temperature is it outside? ");
                temp = double.Parse(Console.ReadLine());
                // if it is a work day, see if it is below freezing
                if (temp > FREEZE)
                {
                    // prompt the user to go to work.
                    Console.WriteLine("Go to work.");
                }
                // else prompt the user to dress warmly.
                else
                {
                    Console.WriteLine("Go to work and dress warmly.");
                }
            }
            // if it was saturday or sunday, then no work!
            else
            {
                // it is a workday, display the go to work message
                Console.WriteLine("Yeah! No work today!");
            }
            // keep the cursor there until the user preses enter.
            Console.ReadLine();
            /*
            Questions:

            int num1 = 5;
            int num2 = 8;
            const int MAX = 10;

            (1) Keeping in mind the shortcut rule for evaluating a boolean expression, what is the value of the following expression? You should assume that x has been properly declared, but we do not know the value of x.

            ((num1<MAX && num2<MAX) || x<MAX)
            True

            (2) Now let the value of x be 2. What is the value of this expression?

            ((num1<MAX && num2> MAX) || x < MAX)
            True
            */
        }//End Main()
    }
}

