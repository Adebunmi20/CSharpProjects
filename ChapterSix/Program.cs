using System;

namespace ChapterSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Question 1 =====");
            //Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
            Console.Write("Enter any number you want the range to be: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i + " ");
            }

            //Question 2
            /*Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number 
            N should be read from the standard input.*/
            Console.WriteLine("Enter any number");
            int length = int.Parse(Console.ReadLine());

            for (int i = 1; i < length; i++);
            {
                if (i % (3 * 7) != 0)
                {
                    Console.WriteLine(i);
                }
            }
            //Question 3
            //Write a program that reads from the console a series of integers and prints the smallest and largest of them.
            //Question 4
            /*Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 
            cards).*/
             for (int i = 0; i < 4; i++);
            {
                if (a = 0; a < 13; a++;)
                {
                    switch (i)
                    {
                        case 0: Console.Write("Club "); 
                        break;
                        case 1: Console.Write("Diamond "); 
                        break;
                        case 2: Console.Write("Heart "); 
                        break;
                        case 3: Console.Write("Spades "); 
                        break;
                    }
                    switch (a)
                    {
                        case 0: Console.WriteLine("2"); 
                        break;
                        case 1: Console.WriteLine("3"); 
                        break;
                        case 2: Console.WriteLine("4"); 
                        break;
                        case 3: Console.WriteLine("5"); 
                        break;
                        case 4: Console.WriteLine("6"); 
                        break;
                        case 5: Console.WriteLine("7"); 
                        break;
                        case 6: Console.WriteLine("8"); 
                        break;
                        case 7: Console.WriteLine("9"); 
                        break;
                        case 8: Console.WriteLine("10"); 
                        break;
                        case 9: Console.WriteLine("J"); 
                        break;
                        case 10: Console.WriteLine("Q"); 
                        break;
                        case 11: Console.WriteLine("K"); 
                        break;
                        case 12: Console.WriteLine("A"); 
                        break;
                    }
                }
            }
            //Question 5
            /*Write a program that reads from the console number N and print the sum of the first N members of the Fibonacci sequence: 0, 1, 1, 
            2, 3, 5, 8 13, 21, 34, 55, 89, 144, 233, 377, …*/
            int n = 100;
                int f1 = 0, f2 = 1, i;

            if (n < 1)
            return;
            for (i = 1; i < n; i++)
            {
                Console.Write(f2 +" ");
                int next = f1 + f2;
                f1 = f2;
                f2 = next;
            }
            //Question 6
            //Write a program that calculates N!/K! for given N and K (1<K<N).
            //Question 7
            //Write a program that calculates N!*K!/(N-K)! for given N and K (1<K<N).
            //Question 8
            /*In combinatorics, the Catalan numbers are calculated by the following formula: Write a program that calculates the nth Catalan 
            number by given n.*/
            //Quesyion 9
            //Write a program that for a given integers n and x, calculates the sum:
            //Question 10
            /*Write a program that reads from the console a positive integer number N (N < 20) and prints a matrix of numbers as on the figures 
            below:*/
            //Question 11
            /*Write a program that calculates with how many zeroes the factorial of a given number ends. Examples: N = 10 -> N! = 3628800 -> 2
            N = 20 -> N! = 2432902008176640000 -> 4*/
            //Question 12
            //Write a program that converts a given number from decimal to binary notation (numeral system).
            //Question 13
            //Write a program that converts a given number from binary to decimal notation.
            //Question 14
            //Write a program that converts a given number from decimal to hexadecimal notation.
            //Question 15
            //Write a program that converts a given number from hexadecimal to decimal notation.
            //Question 16
            //Write a program that by a given integer N prints the numbers from 1 to N in random order.
            //Question 17
            /*Write a program that given two numbers finds their greatest common divisor (GCD) and their least common multiple (LCM). You may use
            the formula LCM(a, b) = |a*b| / GCD(a, b).*/
            //Question 18
            //Write a program that for a given number n, outputs a matrix in the form of a spiral: Example for n=4:
        }
    }
}
