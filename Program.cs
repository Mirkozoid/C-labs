using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements array");
            int numberElements = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numberElements];
            Console.Clear();
            Random randomElement = new Random();
            Console.WriteLine("Number of array elements: " + numberElements);
            for (int i = 0; i < numberElements; i++)
            {
                array[i] = randomElement.Next(1, 150);
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
            Console.Clear();
            sortingInserts(numberElements, array);
            Console.Clear();
            sortingBubble(numberElements, array);
            Console.Clear();
            sortingChoice(numberElements, array);
        }
        static void sortingInserts(int numberElements, int[] array)
        {
            int index;
            int desiredNumber;
            Console.WriteLine("Sorting by insert");
            Console.WriteLine("Number of array elements: " + numberElements);
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
        static void sortingBubble(int numberElements, int[] array)
        {
            int temp;
            Console.WriteLine("Sorting bubble");

            for (int i = 0; i < numberElements; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
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
        static void sortingChoice(int numberElements, int[] array)
        {
            int index;
            int desiredNumber;
            Console.WriteLine("Sorting by choise");
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
