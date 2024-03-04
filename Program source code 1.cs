namespace Question1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            num3 = Convert.ToInt32(Console.ReadLine());
            int[] numbers = {num1, num2, num3};
            Array.Sort(numbers);
            Console.WriteLine("The numbers in ascending order are:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number + " ");
            }

        }
    }
}
