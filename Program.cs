using System;
namespace Sample_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "Polyilaro";
            
            //Declaring additional variable
            int i2;
            double d2;
            string s2;

            // Read and initializing variable
            Console.WriteLine("Enter an integer value");
            i2 = 
                Convert .ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a double value");
            d2 = 
                Convert .ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a string message");
             s2 = Console.ReadLine();

            // printing the sum of both inter value

            Console.WriteLine(i + i2);

            // printing the sum of the double value
            double doublesum = d + d2;
            Console.WriteLine(doublesum);

            // Concatenating and printing the string variable
            Console.WriteLine(s + s2);
           



        }

    }
}
