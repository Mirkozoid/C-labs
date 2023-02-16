using System;
using System.IO;
namespace Pac
{
    class Program
    {
        static void Main(string[] args)
        {
            State Value = new State();
            Console.CursorVisible = false;
            char[,] map = ReadMap("map.txt");
            while (true)
            {
                Console.Clear();                

                DrawMap(map);
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Score: " + Value.Score);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(Value.PacManX, Value.PacManY);
                Console.Write("@");

                ConsoleKeyInfo pressedKey = Console.ReadKey();
                HandleInput(pressedKey, ref Value.PacManX, ref Value.PacManY, map , ref Value.Score);
            }
        }

        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines("map.txt");
            char[,] map = new char[GetMaxOfTheLength(file), file.Length];
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    map[x, y] = file[y][x];
                }
            }
            return map;
        }

        private static void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    if (map[x, y] == '.')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    Console.Write(map[x, y]);
                }
                Console.Write("\n");
            }

        }

        private static void HandleInput(ConsoleKeyInfo pressedKey, ref int pacManX, ref int pacManY, char[,] map, ref int score)
        {
            int[] direction = GetDirection(pressedKey);
            int nextPacManPositionX = pacManX + direction[0];
            int nextPacManPositionY = pacManY + direction[1];
            if (map[nextPacManPositionX, nextPacManPositionY] == ' ')
            {
                pacManX = nextPacManPositionX;
                pacManY = nextPacManPositionY;
            }
            else if (map[nextPacManPositionX, nextPacManPositionY] == '.')
            {
                score += 1;
                map[pacManX, pacManY] = ' ';
                pacManX = nextPacManPositionX;
                pacManY = nextPacManPositionY;
                if (map[pacManX, pacManY] == '.')
                {                   
                    map[pacManX, pacManY] = ' ';
                }
            }
        }

        private static int[] GetDirection(ConsoleKeyInfo pressedKey)
        {
            int[] direction = { 0, 0 };
            if (pressedKey.Key == ConsoleKey.UpArrow)
            {
                direction[1] = -1;
            }
            else if (pressedKey.Key == ConsoleKey.DownArrow)
            {
                direction[1] = 1;
            }
            else if (pressedKey.Key == ConsoleKey.RightArrow)
            {
                direction[0] = 1;
            }
            else if (pressedKey.Key == ConsoleKey.LeftArrow)
            {
                direction[0] = -1; 
            }
            return direction;
        }

        private static int GetMaxOfTheLength(string[] lines)
        {
            int maxLength = lines[0].Length;
            foreach (var line in lines)
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }
            return maxLength;
        }
    }
        class State
        {
            public int PacManX = 11;
            public int PacManY = 6;
            public int Score = 0;
        }
}
