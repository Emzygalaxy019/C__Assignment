using System;
namespace Question6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number;
            String message;
            Console.WriteLine("Enter a number: ");
             number = Convert.ToInt32(Console.ReadLine());

            if (number > 0) {
                message = "The number is positive.";
            }
            else if (number < 0) {
                message = "The number is negative.";
            }
            else
            {
                message = "The number is zero.";
            }

            Console.WriteLine("The number you entered is: " + number);
            Console.WriteLine(message);

            
 
        }
    }
}
