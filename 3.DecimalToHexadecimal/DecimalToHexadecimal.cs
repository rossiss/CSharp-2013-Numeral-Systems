using System;

namespace _3.DecimalToHexadecimal
{
    public class DecimalToHexadecimal
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a number: ");

            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("The value in hexadecimal format is: {0:X}", number);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
