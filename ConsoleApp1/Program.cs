using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            
            int  b = int.Parse(Console.ReadLine());
            array = new int[b];
            Console.WriteLine(array[2]);
            Console.ReadKey();

        }
    }
}
