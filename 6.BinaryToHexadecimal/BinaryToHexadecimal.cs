using System;

namespace _6.BinaryToHexadecimal
{
    public class BinaryToHexadecimal
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a number in binary format: ");

            try
            {
                string number = Console.ReadLine();
                string hex = Convert.ToString(Convert.ToInt32(number, 2), 16);

                Console.WriteLine("The hexadecimal value of the number is: {0}", hex);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }


    }
}