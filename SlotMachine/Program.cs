// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            const int ROWS = 3;
            const int COLUMNS = 3;
            const int LOW_NUMBER = 1;
            const int HIGH_NUMBER = 10;

            int[,] slotMachine = new int[ROWS, COLUMNS];

            Console.WriteLine("Please play the Slot Machine");
            
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    slotMachine[i, j] = rng.Next(LOW_NUMBER, HIGH_NUMBER);
                }
            }
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    Console.Write(slotMachine[i, j]);
                }
                Console.WriteLine();
            }
            bool isWin = false;
            for (int i = 0; i < ROWS; i++)
            {
                if (slotMachine[i, 0] == slotMachine[i, 1] && slotMachine[i, 1] == slotMachine[i, 2])
                {
                    isWin = true;
                    break;
                }
            }

            Console.WriteLine(isWin ? "Congratulations, you win!" : "Try again!");
        }
    }
}

