using System;

namespace ChapterEight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            //Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system.
            string decimalValue1 = "151";
            int binaryValue1 = Convert.ToInt32(decimalValue1, 10);
            string convertBinary1 = Convert.ToString(binaryValue1, 2);
            Console.WriteLine($"The result of the conversion is {convertBinary1}");
            string decimaValue = "35";
            int binaryValue = Convert.ToInt32(decimaValue, 10);
            string conBin = Convert.ToString(binaryValue, 2);
            Console.WriteLine($"The result of the conversion is {conBin}");
            string decimalValue2 = "43";
            int binaryValue2 = Convert.ToInt32(decimalValue2, 10);
            string converbin = Convert.ToString(binaryValue2, 2);
            Console.WriteLine($"The result of the conversion is {converbin}");
            string decimalValue3 = "251";
            int binaryValue3 = Convert.ToInt32(decimalValue3, 10);
            string conBin3 = Convert.ToString(binaryValue3, 2);
            Console.WriteLine($"The result of the conversion is {conBin3}");
            string decimaValue4 = "1023";
            int binaryValue4 = Convert.ToInt32(decimaValue4, 10);
            string conBin4 = Convert.ToString(binaryValue4, 2);
            Console.WriteLine($"The result of the conversion is {conBin4}");
            string decimaValue5 = "1024";
            int binaryValue5 = Convert.ToInt32(decimaValue5, 10);
            string conBin5 = Convert.ToString(binaryValue5, 2);
            Console.WriteLine($"The result of the conversion is {conBin5}");
            
            //Question 2
            //Convert the number 1111010110011110(2) to hexadecimal and decimal numeral systems.
            long binarynum = 1111010110011110;
            string convertBinary = Convert.ToString(binarynum, 2);
            int decimalValue = Convert.ToString(convertBinary, 10);
            string hexadecimal = Convert.ToString(decimalValue, 16);
            Console.WriteLine($"The result of the conversions are {hexadecimal} and {decimalValue}.");



            /*//Question 3
            //Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and decimal numeral systems.
            Console.WriteLine("===== Question 4 =====");
            //Write a program that converts a decimal number to binary one.
            Console.WriteLine("Enter any decimal number");
            string decimalVal = Convert.ToString(Console.ReadLine());
            int binaryVal = Convert.ToInt32(decimalVal, 10);
            string convertBin = Convert.ToString(binaryVal, 2);
            Console.WriteLine($"The result of the conversion is {convertBin}");
            Console.WriteLine("===== Question 5 =====");
            //Write a program that converts a binary number to decimal one.
            Console.WriteLine("Enter any binary number");
            string binaryNum = Convert.ToString(Console.ReadLine());
            int decValue = Convert.ToInt32(binaryNum, 2);
            Console.WriteLine($"The result of the conversion is {decValue}");
            Console.WriteLine("===== Question 6 =====");
            //Write a program that converts a decimal number to hexadecimal one.
            Console.WriteLine("Enter any decimal number: ");
            int a = int.Parse(Console.ReadLine());
            //string toDec = Convert.ToString(d, 10);
            string hexDec = Convert.ToString(a, 16);
            Console.WriteLine($"The result of the conversion is {hexDec}");
            Console.WriteLine("===== Question 7 =====");
            //Write a program that converts a hexadecimal number to decimal one.
            Console.WriteLine("Enter a hexadecimal number");
            string hexadecimal = Convert.ToString(Console.ReadLine());
            int decimValue = Convert.ToInt32(hexadecimal, 16);
            Console.WriteLine($"The result of the conversion is {decimValue}");
            Console.WriteLine("===== Question 8 =====");
            //Write a program that converts a hexadecimal number to binary one.
            Console.WriteLine("Enter any hexadecimal number");
            string hexaDec = Convert.ToString(Console.ReadLine());
            int decVal = Convert.ToInt32(hexaDec, 16);
            string convertToBinary = Convert.ToString(decVal, 2);
            Console.WriteLine($"The result of the conversion is {convertToBinary}");
            Console.WriteLine("===== Question 9 =====");
            //Write a program that converts a binary number to hexadecimal one.
            Console.WriteLine("Enter a binary number");
            string binaryNumber = Convert.ToString(Console.ReadLine());
            int decimalValue = Convert.ToInt32(binaryNumber, 2);
            String hexDecimal = Convert.ToString(decimalValue, 16);
            Console.WriteLine($"The result of the conversion is {hexDecimal}");
            //Question 10
            //Write a program that converts a binary number to decimal using the Horner scheme.
            //Question 11
            //Write a program that converts Roman digits to Arabic ones.
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case (2 / 1000):
                //case 2:
                Console.WriteLine("C", "D" , "M");
                break;
            }
            //Question 12
            //Write a program that converts Arabic digits to Roman ones.
            //Question 13
            /*Write a program that by given N, S, D (2 ≤ S, D ≤ 16) converts the number N from an S-based numeral system to a D based numeral
            system.*/
            //Question 14
            /*Try adding up 50,000,000 times the number 0.000001. Use a loop and addition (not direct multiplication). Try it with float and
            double and after that with decimal. Do you notice the huge difference in the results and speed of calculation? Explain what happens.*/
            //Question 15
            /*Write a program that prints the value of the mantissa, the sign of the mantissa and exponent in float numbers (32-bit numbers with
            a floating-point according to the IEEE 754 standard). Example: for the number -27.25 should be printed: sign = 1, exponent = 
            10000011, mantissa = 10110100000000000000000.*/

        }
    }
}
