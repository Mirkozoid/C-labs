using System;

namespace sorting_by_choice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements array");
            int numberElements = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numberElements];
            int temp;
            int min;
            Random randomElement = new Random();
            for (int i = 0; i < numberElements; i++)
            {
                array[i] = randomElement.Next(1, 150);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < numberElements; i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;                       
                    }
                }
                temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
            for (int i = 0; i < numberElements; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
