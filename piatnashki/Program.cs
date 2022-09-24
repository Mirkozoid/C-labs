using System;

namespace piatnashki
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                int[,] array = new int[4, 4];
                Random random = new Random();
                int[] numbers = new int[16];
                int ind = 0;
                int a = 0;
                for (int i = 0; i < numbers.Length; i++)
                {


                    numbers[i] = a;
                    a++;
                }
                for (int i = numbers.Length - 1; i >= 1; i--)
                {
                    int j = random.Next(i + 1);
                    var temp = numbers[j];
                    numbers[j] = numbers[i];
                    numbers[i] = temp;
                }
                for (int i = 0; i < array.GetLength(0); i++)
                {

                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                        array[i, j] = numbers[ind];
                        ind++;
                    }
                }
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine();
                }
                Console.ReadKey();
                while (true)
                {
                    Console.WriteLine("select the number you want to change from 0");
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        int index = 0;
                        int ger = 0;
                        int newIndex = 0;
                        int newGer = 0;
                        for (int i = 0; i < 4; i++)
                        {
                            for (int g = 0; g < 4; g++)
                            {
                                if (array[i, g] == 0)
                                {
                                    index = i;
                                    ger = g;
                                    for (int l = 0; l < 4; l++)
                                    {
                                        for (int j = 0; j < 4; j++)
                                        {

                                            if (array[l, j] == number)
                                            {
                                                newIndex = l;
                                                newGer = j;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (newIndex == index)
                        {
                            if (newGer < ger + 2 && newGer > ger - 2)
                            {
                                Console.WriteLine("rr");
                                for (int p = 0; p < 1; p++)
                                {
                                    var temp = array[index, ger];
                                    array[index, ger] = array[newIndex, newGer];
                                    array[newIndex, newGer] = temp;
                                }
                                Console.Clear();
                                for (int k = 0; k < array.GetLength(0); k++)
                                {
                                    for (int o = 0; o < array.GetLength(1); o++)
                                    {
                                        Console.Write(array[k, o] + "\t");
                                    }
                                    Console.WriteLine(" ");
                                    Console.WriteLine();
                                }
                            }
                        }
                        if (newGer == ger)
                        {
                            if (newIndex < index + 2 && newIndex > index - 2)
                            {
                                Console.WriteLine("rr");
                                for (int p = 0; p < 1; p++)
                                {
                                    var temp = array[index, ger];
                                    array[index, ger] = array[newIndex, newGer];
                                    array[newIndex, newGer] = temp;
                                }
                                Console.Clear();
                                for (int k = 0; k < array.GetLength(0); k++)
                                {
                                    for (int o = 0; o < array.GetLength(1); o++)
                                    {
                                        Console.Write(array[k, o] + "\t");
                                    }
                                    Console.WriteLine(" ");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                        Console.ReadKey();
                        Console.Clear();

                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                Console.Write(array[i, j] + "\t");
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine();

                        }
                        Console.ReadKey();
                        
                    }



                }


            }
        }
    }
}
