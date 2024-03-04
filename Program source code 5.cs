using System;
namespace Question5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float[] alpha = new float[50];
            for (int i = 0; i < 25; i++) {
                alpha[i] = i * i;
            }

            for (int i = 25; i < 50; i++)
            {
                alpha[i] = 3 * i;
            }

            Console.WriteLine("The array alpha is:");

            for(int i = 0; i < 50; i++) {
                Console.WriteLine(alpha[i] + " ");

                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }

            }
           

        }
    }
}
