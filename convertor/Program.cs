using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for convert");
            int length;
            double number = 0;
            int index = 0;
            int separationIndex = 0;
            char[] convertedString = Console.ReadLine().ToCharArray();
            length = convertedString.Length;
            double[] fieldNumber = new double[length];
            for (int i = 0; i < length; i++)
            {
                if (convertedString[i] == ',' || convertedString[i] == '.')
                {
                    if (convertedString[0] == '-')
                    {
                        convertedString[0] = '0';
                    }
                    convertedString[i] = '0';
                    int degree = i;
                    fieldNumber[i] = char.GetNumericValue(convertedString[i]);
                    separationIndex = i;
                    for (int j = 0; j < length - 1 - i; j++)
                    {
                        int indexForNumberAfterPoint = j + i;
                        indexForNumberAfterPoint++;
                        fieldNumber[indexForNumberAfterPoint] = char.GetNumericValue(convertedString[indexForNumberAfterPoint]);
                        fieldNumber[indexForNumberAfterPoint] = fieldNumber[indexForNumberAfterPoint] / Math.Pow(10, j + 1);
                    }
                    for (int j = 0; j < i; j++)
                    {
                        int indexForNumberBeforePoint = j;
                        fieldNumber[indexForNumberBeforePoint] = char.GetNumericValue(convertedString[indexForNumberBeforePoint]);
                        fieldNumber[indexForNumberBeforePoint] = fieldNumber[indexForNumberBeforePoint] * Math.Pow(10, degree - 1);
                        degree--;
                    }
                    break;
                }
                else
                {
                    if (convertedString[0] == '-')
                    {
                        convertedString[0] = '0';
                    }
                    index = length;
                    for (int j = 0; j < length; j++)
                    {

                        index--;
                        fieldNumber[j] = char.GetNumericValue(convertedString[j]);
                        fieldNumber[j] = fieldNumber[j] * Math.Pow(10, index);
                    }
                }
            }
            if (fieldNumber[0] == 0)
            {
                for (int i = 0; i < length; i++)
                {
                    number += fieldNumber[i];
                }
                number = Math.Abs(number) * (-1);
            }
            if (fieldNumber[0] != 0)
            {
                for (int i = 0; i < length; i++)
                {
                    number += fieldNumber[i];
                }
            }
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
