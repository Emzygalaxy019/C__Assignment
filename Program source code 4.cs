namespace Question4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[rows, columns];
            int[,] matrix2 = new int[rows, columns];
            int[,] sumMatrix = new int[rows, columns];

            Console.WriteLine("Enter the elements of the first matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the elements of the second matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            Console.Write("The sum of the matrices is: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(sumMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
