using System;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("===== Question 1 =====");
          /*Declare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, ushort, int, uint, 
            long and ulong in order to assign them the following values: 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44;
            -1,000,000; 1990; 123456789123456789.*/
            long number1 =  123456789123456789;
            Console.WriteLine(number1);
            int number2 = 97;
            Console.WriteLine(number2);
            uint number3 = 4825932;
            Console.WriteLine(number3);
            byte number4 = 112;
            Console.WriteLine(number4);
            short number5 = 1990;
            Console.WriteLine(number5);
            sbyte number6 = -115;
            Console.WriteLine(number6);
            ushort number7 = 20000;
            Console.WriteLine(number7);
            ulong number8 =  970700000;
            Console.WriteLine(number8);
            
            Console.WriteLine("===== Question 2 =====");
          /*Which of the following values can be assigned to variables of type float,double and decimal: 5, -5.01, 34.567839023; 12.345; 
            8923.1234857;3456.091124875956542151256683467?*/
            decimal figure = 3456.091124875956542151256683467m;
            Console.WriteLine(figure);
            float figure2 = 12.345f;
            Console.WriteLine(figure2);
            double figure3 = 8923.1234857;
            Console.WriteLine(figure3);

            Console.WriteLine("===== Question 3 =====");
          //Write a program, which compares correctly two real numbers with accuracy at least 0.000001.
            float a = 109.003f;
            float b = 18632.903f;
            bool equal = Math.Abs(a - b) < 0.000001;
            Console.WriteLine(equal);

            Console.WriteLine("===== Question 4 =====");
          //Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).
            int numberInDec = 16;
            int numberInHex = 0x10;
            Console.WriteLine(numberInHex);


            //Question 5
          /*Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in 
            order to find hexadecimal representation of 72).*/

            Console.WriteLine("===== Question 6=====");
          //Declare a variable isMale of type bool and assign a value to it depending on your gender.
            bool isMale = true;
            if(isMale == true);
            {
              Console.WriteLine("You are a male");
            }
            if(isMale != true);
            {
              Console.WriteLine("You are a female");
            }

            Console.WriteLine("===== Question 7 =====");
          /*Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. Assign the value obtained 
            of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.*/
            String firstWord = "Hello";
            String secondWord = "World";
            var concatination1 = firstWord + " " + secondWord;
            Console.WriteLine("The concatination of " + firstWord +" and "+ secondWord + " is " + concatination1);
            Console.WriteLine("===== Question 8 =====");
          /*Declare two variables of type string and give them values "Hello" and "World". Assign the value obtained by the concatenation of the 
            two variables of type string (do not miss the space in the middle) to a variable of type object. Declare a third variable of type 
            string and initialize it with the value of the variable of type object (you should use type casting).*/
            string Word1 = "Hello";
            string Word2 = "World";
            string concatenation = Word1 + " " + Word2;
            Console.WriteLine(concatenation);
            Console.WriteLine("===== Question 9 =====");
          /*Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without the outer 
            quotes). In one of the variables use quoted string and in the other do not use it.*/
            Console.WriteLine("The use of quotation causes difficulties");
            Console.WriteLine("The \"use\" of quotation causes difficulties");
            Console.WriteLine("===== Question 10 =====");
          //Write a program to print a figure in the shape of a heart by the sign "o".
            Console.WriteLine(" o  o    o o ");
            Console.WriteLine(" o    o    o");
            Console.WriteLine("  o       o");
            Console.WriteLine("   o     o");
            Console.WriteLine("    o   o");
            Console.WriteLine("     ooo  ");
            Console.WriteLine("===== Question 11 =====");
          //Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©"
            Console.WriteLine("    @");
            Console.WriteLine("   @  @");
            Console.WriteLine("  @    @");
            Console.WriteLine(" @      @");
            Console.WriteLine("@        @");
            Console.WriteLine("@@@@@@@@@@");
            Console.WriteLine("===== Question 12 =====");
          /*A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic
            – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables 
            needed to maintain the information for an employee by using the appropriate data types and attribute names.*/
            Console.Write("Enter your first name: ");
            string firstname = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastname = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your gender: ");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter your phone number: ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("=====Question 13=====");
          //Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.
          int num1 = 5;
          int num2 = 10;
          num1 = num2;
          Console.WriteLine(num2);
          num2 = num1;
          Console.WriteLine(num1);

        }
    }
}
