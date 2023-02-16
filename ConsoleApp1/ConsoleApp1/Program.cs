using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            Tables[] Table = { new Tables(1, 6), new Tables(2, 1), new Tables(3, 9), new Tables(4, 6),
            new Tables(5, 2), new Tables(6, 6), new Tables(7, 5), new Tables(8, 3), };
            while (isOpen)
            {
                Console.WriteLine("Hello, it is cafe Fat Man, free tables:");
                for (int i = 0; i < Table.Length; i++)
                {
                    Table[i].ShowInfo();
                }
                Console.Write("\n Which table would you like to book ?\n Enter the number of table:");
                int wishNumber = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write($"\n How many seats do you want to book ?\n \n Free places {Table[wishNumber].FreePlaces} \n Enter the number of seats:");
                int numberOfSeats = Convert.ToInt32(Console.ReadLine());

                bool isReservationCompleted = Table[wishNumber].Reserve(numberOfSeats);

                if (isReservationCompleted)
                {
                    Console.WriteLine("\n Reservation completed successful");
                }
                else
                {
                    Console.WriteLine("\n Not enough seats");
                }

                Console.ReadKey();
                Console.Clear();
            }            
        }
    }    
    class Tables
    {
        public int Number;
        public int MaxPlaces;
        public int FreePlaces;
        public Tables(int number, int maxPlaces)
        {
            Number = number;
            MaxPlaces = maxPlaces;
            FreePlaces = maxPlaces;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Table: {Number}. " +
                $"\n Free places: {FreePlaces} out {MaxPlaces}");
        }
        public bool Reserve(int places)
        {
            if (FreePlaces >= places)
            {
                FreePlaces -= places;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
