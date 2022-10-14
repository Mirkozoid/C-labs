using System;

namespace bubble_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements array");
            int numberElements = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numberElements];
            int temp;
            Random randomElement = new Random(); 
            for (int i = 0; i < numberElements; i++)
            {
                array[i] = randomElement.Next(1, 150);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < numberElements; i++)
            {
                for (int j = 0; j < array.Length-1-i; j++)
                {
                   if (array[j] > array[j + 1])
                   {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;                        
                   }
                }                   
            }
            for (int i = 0; i < numberElements; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
