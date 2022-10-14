using System;

namespace sorting_by_inserts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements array");
            int numberElements = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numberElements];
            int index;
            int temp;
            int desiredNumber;
            Random randomElement = new Random();
            for (int i = 0; i < numberElements; i++)
            {
                array[i] = randomElement.Next(1, 150);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < numberElements; i++)
            {
                index = i;
                desiredNumber = array[i];
                while (index > 0 && desiredNumber < array[index - 1])
                {
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = desiredNumber;
            }
            for (int i = 0; i < numberElements; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
