using System;

namespace _8.ShortToBinary
{
    public class ShortToBinary
    {
        public static void Main()
        {
            Console.WriteLine("Please write a 16-bit signed integer: ");

            try
            {
                ushort number = ushort.Parse(Console.ReadLine());
                Console.WriteLine("The binary value of the number is: \n{0}", Convert.ToString(number, 2));
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
