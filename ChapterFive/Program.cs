using System;

namespace ChapterFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Question 1=====");
            //Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.
            Console.WriteLine("Enter the first integer number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
            //Question 2
            /*Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if 
            operators.*/
            Console.WriteLine("===== Question 3 =====");
            //Write a program that finds the biggest of three integers, using nested if statements.
            Console.WriteLine("Enter the first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int third = Convert.ToInt32(Console.ReadLine());
            if ((first > second) && (first > third))
            {
                Console.WriteLine($"The biggest number is {first}");
            }
            else
            {
                if ((second > third) && (second > first))
                {
                    Console.WriteLine($"The biggest number is {second}");
                }
                else
                {
                    Console.WriteLine($"The biggest number is {third}");
                }
            }
            Console.WriteLine("=====Question 4=====");
            //Sort 3 real numbers in descending order. Use nested if statements.
            Console.WriteLine("Enter the first number: ");
            int real = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int real2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int real3 = Convert.ToInt32(Console.ReadLine());
            if((real > real2) && (real> real3))
            {
                Console.WriteLine($"The arrangement of the number in descending order is {real3}, {real2}, {real}");
            }
            else
            {
                if((real2 > real) && (real2 > real3))
                {
                    Console.WriteLine($"The arrangement of the number in descending order is {real2}, {real}, {real3}");
                }
                else
                {
                    Console.WriteLine($"The arrangement of the number in descending order is {real}, {real2}, {real3}");
                }
            }
            Console.WriteLine("===== Question 5 =====");
            /*Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch 
            statement.*/
            Console.WriteLine("Enter any number from 0-9");
            String number = Console.ReadLine();
            switch(number)
            {
                case "0":
                Console.WriteLine("Zero");
                break;
                case "1":
                Console.WriteLine("One");
                break;
                case "2":
                Console.WriteLine("Two");
                break;
                case "3":
                Console.WriteLine("Three");
                break;
                case "4":
                Console.WriteLine("Four");
                break;
                case "5":
                Console.WriteLine("Five");
                break;
                case "6":
                Console.WriteLine("Six");
                break;
                case "7":
                Console.WriteLine("Seven");
                break;
                case "8":
                Console.WriteLine("Eight");
                break;
                case "9":
                Console.WriteLine("Nine");
                break;
            
                default:
                Console.WriteLine("Invalid digit, input a valid one"); 
                break;
            }
            //Question 6
            /*Write a program that gets the coefficients a, b and c of a quadratic equation: ax^2 + bx + c, calculates and prints its real roots 
            (if they exist). Quadratic equations may have 0, 1 or 2 real roots.*/
            Console.WriteLine("===== Question 7 =====");
            //Write a program that finds the greatest of given 5 numbers.
            Console.WriteLine("Enter the first number");
            int firstNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int thirdNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the forth number");
            int forthNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fifth number");
            int fifthNo = Convert.ToInt32(Console.ReadLine());
            if((firstNo > secondNo) && (firstNo > thirdNo) && (firstNo > forthNo) && (firstNo > fifthNo))
            {
                Console.WriteLine($"The greatest number {firstNo}");
            }
            if((secondNo > firstNo) && (secondNo > thirdNo) && (secondNo > forthNo) && (secondNo > fifthNo))
            {
                Console.WriteLine($"The greatest number {secondNo}");
            }
            if((thirdNo > secondNo) && (thirdNo > firstNo) && (thirdNo > forthNo) && (thirdNo > fifthNo))
            {
                Console.WriteLine($"The greatest number {thirdNo}");
            }
            if((forthNo > secondNo) && (forthNo > thirdNo) && (forthNo > firstNo) && (forthNo > fifthNo))
            {
                Console.WriteLine($"The greatest number {forthNo}");
            }
            if((fifthNo > secondNo) && (fifthNo > thirdNo) && (fifthNo > forthNo) && (fifthNo > firstNo))
            {
                Console.WriteLine($"The greatest number {fifthNo}");
            }
            //Question 8
            /*Write a program that, depending on the user’s choice, inputs int, double or string variable. If the variable is int or double, the 
            program increases it by 1. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use 
            switch statement.*/
            //Question 9
            /*We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:
            - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.
            - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0.*/
            Console.WriteLine("=====Question 10 =====");
            /*Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
            - If the score is between 1 and 3, the program multiplies it by 10.
            - If the score is between 4 and 6, the program multiplies it by 100.
            - If the score is between 7 and 9, the program multiplies it by 1000.
            - If the score is 0 or more than 9, the program prints an error message.*/
            Console.WriteLine("Enter any number from 1-9");
            String numbers = Console.ReadLine();
            switch(numbers)
            {
                case "1":
                Console.WriteLine(1*10);
                break;
                case "2":
                Console.WriteLine(2*10);
                break;
                case "3":
                Console.WriteLine(3*10);
                break;
                case "4":
                Console.WriteLine(4*100);
                break;
                case "5":
                Console.WriteLine(5*100);
                break;
                case "6":
                Console.WriteLine(6*100);
                break;
                case "7":
                Console.WriteLine(7*1000);
                break;
                case "8":
                Console.WriteLine(8*1000);
                break;
                case "9":
                Console.WriteLine(9*1000);
                break;

                default: 
                Console.WriteLine("Invalid digit, input a valid one"); 
                break;
            }
            //Question 11
            /*Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:
            - 0 --> "Zero"
            - 12 --> "Twelve"
            - 98 --> "Ninety eight"
            - 273 --> "Two hundred seventy three"
            - 400 --> "Four hundred"
            - 501 --> "Five hundred and one"
            - 711 --> "Seven hundred and eleven"*/
        }
    }
}
