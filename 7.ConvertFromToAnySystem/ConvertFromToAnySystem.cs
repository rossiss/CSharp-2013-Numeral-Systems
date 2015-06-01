using System;
using _1.DecimalToBinary;
using _2.BinaryToDecimal;
using _3.DecimalToHexadecimal;
using _4.HexadecimalToDecimal;
using _5.HexadecimalToBinary;
using _6.BinaryToHexadecimal;

namespace _7.ConvertFromToAnySystem
{
    public class ConvertFromToAnySystem
    {
        static void Main()
        {
            Console.WriteLine("Please choose the input numeral system (2, 10 or 16): ");
            Console.WriteLine("2.Binary");
            Console.WriteLine("10.Decimal");
            Console.WriteLine("16.Hexadecimal");
            int input = int.Parse(Console.ReadLine());

            if ((input != 2) && (input != 10) && (input != 16))
            {
                Console.WriteLine("Invalid input of choice!");
                goto end;
            }
            Console.WriteLine();

            Console.WriteLine("Please choose the output numeral system (2, 10 or 16): ");
            Console.WriteLine("2.Binary");
            Console.WriteLine("10.Decimal");
            Console.WriteLine("16.Hexadecimal");
            int output = int.Parse(Console.ReadLine());

            if ((output != 2) && (output != 10) && (output != 16))
            {
                Console.WriteLine("Invalid input of choice!");
                goto end;
            }
            Console.WriteLine();

            Choices(input, output);

        end: Console.WriteLine("Please try again!");
        }

        public static void Choices(int input, int output)
        {
            switch (input)
            {
                case 2:
                    if (output == 2)
                    {
                        Console.WriteLine("Invalid conversion! The numeral systems chosen are the same.");
                    }
                    else if (output == 10)
                    {
                        BinaryToDecimal.Main();
                    }
                    else if (output == 16)
                    {
                        BinaryToHexadecimal.Main();
                    }
                    break;
                case 10:
                    if (output == 10)
                    {
                        Console.WriteLine("Invalid conversion! The numeral systems chosen are the same.");
                    }
                    else if (output == 2)
                    {
                        DecimalToBinary.Main();
                    }
                    else if (output == 16)
                    {
                        DecimalToHexadecimal.Main();
                    }
                    break;
                case 16:
                    if (output == 16)
                    {
                        Console.WriteLine("Invalid conversion! The numeral systems chosen are the same.");
                    }
                    else if (output == 2)
                    {
                        HexadecimalToBinary.Main();
                    }
                    else if (output == 10)
                    {
                        HexadecimalToDecimal.Main();
                    }
                    break;
                default: 
                    Console.WriteLine("Conversion error!");
                    break;
            }
        }
    }
}