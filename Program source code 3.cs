namespace Question3
{
    public class Program
    {
        public static void Main(string[] args)
        {
           String text;
            Console.WriteLine("Enter a string");
            text = Console.ReadLine();
            char[] charArray = text.ToCharArray();
            Console.WriteLine("The string in uppercase is : ");
            foreach (char c in charArray)
            {
                Console.Write(char.ToUpper (c));
            }
        }
    }
}
