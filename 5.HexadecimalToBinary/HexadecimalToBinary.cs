using System;

namespace _5.HexadecimalToBinary
{
    public class HexadecimalToBinary
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a hexadecimal number: ");

            try
            {
                string number = Console.ReadLine();
                string binary = Convert.ToString(Convert.ToInt32(number, 16), 2);

                Console.WriteLine("The binary value of the number is: {0}", binary);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}