using System;

namespace _4.HexadecimalToDecimal
{
    public class HexadecimalToDecimal
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a hexadecimal number: ");

            try
            {
                string number = Console.ReadLine();
                int decNumber = Convert.ToInt32(number, 16);

                Console.WriteLine("The value in hexadecimal format is: {0}", decNumber);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}