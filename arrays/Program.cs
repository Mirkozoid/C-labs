using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a quantity element array");
                string text = Console.ReadLine();
                if (int.TryParse(text, out int elements))
                {
                    int[] array = new int[elements];
                    Console.WriteLine("Enter a element array");
                    for (int i = 0; i < elements; i++)
                    {
                        array[i] = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < elements; i++)
                    {
                        Console.Write($"\nArray index {i}:\t");
                        Console.WriteLine(array[i]);
                    }
                    int minElement = array[0];
                    for (int i = 1; i < elements; i++)
                    {
                        if (array[i] < minElement)
                        {
                            minElement = array[i];
                        }

                    }
                    Console.WriteLine("The min element array:\t" + minElement);
                }
                else
                {
                    Console.WriteLine("Error");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
