using System;
using System.Linq;

namespace MID
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number");
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    int[,] array = new int[2 * number - 1, 2 * number - 1];
                    int height = array.GetLength(0);
                    int width = array.GetLength(1);
                    int total = number;
                    int newheigth = height - 1;
                    int luck = height-1;
                    int b = height;
                    int l = height-1;                                        
                    for (int p = 0; p < number-1; p++)
                    {
                        
                        int h = 0;
                        int e = p;
                        int d = p;
                        h = p-1;
                        b--;                                               
                        for (int i = 0; i < luck; i++)
                        {
                            h++;
                            e++;
                            d++;
                            array[p, h] = total;
                            array[h, l] = total;
                            array[b, e] = total;
                            array[d, p] = total;                        }                                                                                                                       
                        l--;                       
                        luck = luck - 2;                        
                        total--;
                    }
                    array[number - 1, number - 1] = 1;
                    for (int first = 0; first < height; first++)
                    {
                        for (int second = 0; second < width; second++)
                        {
                            Console.Write(array[first, second] + " ");
                        }
                        Console.WriteLine();
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                }
                Console.ReadKey();
            }
        }
    }
}
