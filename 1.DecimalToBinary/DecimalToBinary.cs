using System;

namespace _1.DecimalToBinary
{
    public class DecimalToBinary
    {
        public static void Main()
        {
            Console.Write("Please write a number you wish to convert: ");

            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("The binary value of the number is: {0}", Convert.ToString(number, 2));
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
