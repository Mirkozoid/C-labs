using System;

namespace piatnashki
{
    class Program
    {
        static void FieldOutput(int[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i, j] + "\t");
                }
                Console.WriteLine(" ");
                Console.WriteLine();
            }
        }
        static void Main()
        {
            while (true)
            {
                int[,] field = new int[4, 4];
                Random random = new Random();
                int[] numbers = new int[16];
                int initialNumber = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = i;
                }
                for (int i = numbers.Length - 1; i >= 1; i--)
                {
                    int j = random.Next(i + 1);
                    var replacement = numbers[j];
                    numbers[j] = numbers[i];
                    numbers[i] = replacement;
                }
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        field[i, j] = numbers[initialNumber];
                        initialNumber++;
                    }
                }
                FieldOutput(field);
                Console.ReadKey();
                while (true)
                {
                    Console.WriteLine("select the number you want to change from 0");
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        int firstIndexEmptyField = 0;
                        int secondIndexEmptyField = 0;
                        int firstIndexSelectedNumber = 0;
                        int secondIndexSelectedNumber = 0;
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (field[i, j] == 0)
                                {
                                    firstIndexEmptyField = i;
                                    secondIndexEmptyField = j;                                   
                                }
                            }
                        }
                        for (int l = 0; l < 4; l++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (field[l, j] == number)
                                {
                                    firstIndexSelectedNumber = l;
                                    secondIndexSelectedNumber = j;
                                }
                            }
                        }
                        if (firstIndexSelectedNumber == firstIndexEmptyField)
                        {
                            if (secondIndexSelectedNumber < secondIndexEmptyField + 2 && secondIndexSelectedNumber > secondIndexEmptyField - 2)
                            {
                                for (int p = 0; p < 1; p++)
                                {
                                    var replacement = field[firstIndexEmptyField, secondIndexEmptyField];
                                    field[firstIndexEmptyField, secondIndexEmptyField] = field[firstIndexSelectedNumber, secondIndexSelectedNumber];
                                    field[firstIndexSelectedNumber, secondIndexSelectedNumber] = replacement;
                                }
                                Console.Clear();
                                FieldOutput(field);
                            }
                        }
                        if (secondIndexSelectedNumber == secondIndexEmptyField)
                        {
                            if (firstIndexSelectedNumber < firstIndexEmptyField + 2 && firstIndexSelectedNumber > firstIndexEmptyField - 2)
                            {
                                for (int p = 0; p < 1; p++)
                                {
                                    var replacement = field[firstIndexEmptyField, secondIndexEmptyField];
                                    field[firstIndexEmptyField, secondIndexEmptyField] = field[firstIndexSelectedNumber, secondIndexSelectedNumber];
                                    field[firstIndexSelectedNumber, secondIndexSelectedNumber] = replacement;
                                }
                                Console.Clear();
                                FieldOutput(field);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                        Console.ReadKey();
                        Console.Clear();
                        FieldOutput(field);
                        Console.ReadKey();                        
                    }
                }
            }
        }
    }
}
