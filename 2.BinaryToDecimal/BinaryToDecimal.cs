using System;

namespace _2.BinaryToDecimal
{
    public class BinaryToDecimal
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a binary value: ");

            try
            {
                int binaryInput = Convert.ToInt32(Console.ReadLine(), 2);
                Console.WriteLine("The value in decimal format is: {0}", binaryInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input! Only characters accepted are: 1 and 0.");
            }
        }
    }
}
