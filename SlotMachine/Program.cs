// See https://aka.ms/new-console-template for more information
using System;

using System;
using System.ComponentModel;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            const int LOWER_NUMBER = 3;
            const int HIGHER_NUMBER = 3;
             int ROWS = rng.Next(LOWER_NUMBER, HIGHER_NUMBER);
             int COLUMNS = rng.Next(LOWER_NUMBER, HIGHER_NUMBER);
            const int LOW_NUMBER = 1;
            const int HIGH_NUMBER = 4;

            const int FIRST_CHOICE = 1;
            const int SECOND_CHOICE = 2;
            const int THIRD_CHOICE = 3;

            int[,] slots = new int[ROWS, COLUMNS];

            Console.WriteLine("Please play the Slot Machine");
            Console.WriteLine("Press 1 for horizontal win");
            Console.WriteLine("Press 2 for vertical win");
            Console.WriteLine("Press 3 for diagonal win");
            int choice = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    slots[i, j] = rng.Next(LOW_NUMBER, HIGH_NUMBER);
                }
            }
            Console.WriteLine("\nSlot Machine:");
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    Console.Write(slots[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
            bool isWin = false;

            if (choice == FIRST_CHOICE)
            {
                for (int i = 0; i < ROWS; i++)
                {
                    bool rowWin = true;
                    for (int j = 1; j < COLUMNS; j++)
                    {
                        if (slots[i, j] != slots[i, 0])
                        {
                            rowWin = false;
                            break;
                        }
                    }
                    if (rowWin)
                    {
                        isWin = true;
                        break;
                    }
                }
            }
            else if (choice == SECOND_CHOICE)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    bool colWin = true;
                    for (int i = 1; i < ROWS; i++)
                    {
                        if (slots[i, j] != slots[0, j])
                        {
                            colWin = false;
                            break;
                        }
                    }
                    if (colWin)
                    {
                        isWin = true;
                        break;
                    }
                }
            }
            else if (choice == THIRD_CHOICE)
            {
                bool mainDiagonalWin = true;
                for (int i = 1; i < ROWS; i++)
                {
                    if (slots[i, i] != slots[0, 0])
                    {
                        mainDiagonalWin = false;
                        break;
                    }
                }

                bool antiDiagonalWin = true;
                for (int i = 1; i < ROWS; i++)
                {
                    if (slots[i, COLUMNS - 1 - i] != slots[0, COLUMNS - 1])
                    {
                        antiDiagonalWin = false;
                        break;
                    }
                }

                if (mainDiagonalWin || antiDiagonalWin)
                {
                    isWin = true;
                }
            }

            Console.WriteLine(isWin ? "\n🎉 Congratulations, you win!" : "\n❌ Try again!");
        }
    }
}


    



