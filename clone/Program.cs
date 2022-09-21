using System;

namespace clone
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int number = int.Parse(Console.ReadLine());
            
               int[,] array = new int[2 * number - 1, 2 * number - 1];
               int height = array.GetLength(0);
               int width = array.GetLength(1);
               

                for (int first = 0; first < height; first++)
                {
                    for (int second = 0; second < width; second++)
                    {
                        Console.Write(array[first, second] + " ");
                    }
                    Console.WriteLine();
                }
            
                Console.ReadKey();           
        }
    }
}
