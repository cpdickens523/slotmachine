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

            int[,] slots = new int[ROWS, COLUMNS];
           


            Console.WriteLine("Please play the Slot Machine");
            Console.WriteLine("Press 1 for horizontal win");
            Console.WriteLine("Press 2 for vertical win");
            Console.WriteLine("Press 3 for diagonal win");
            int choice = int.Parse(Console.ReadLine());


            for (int k = 0; k < ROWS; k++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    slots[k, j] = rng.Next(LOW_NUMBER, HIGH_NUMBER);
                }

                if (slots[0, 0] == slots[0, 1] && slots[0, 0] == slots[0, 2])
                {
                    continue;
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
                if (choice == 1)
                {
                    for (int i = 0; i < ROWS; i++)
                    {
                        if (slots[i, 0] == slots[i, 1] && slots[i, 1] == slots[i, 2])
                        {
                            isWin = true;
                            break;
                        }
                    }
                }

                else if (choice == 2)
                {
                    for (int j = 0; j < COLUMNS; j++)
                    {
                        if (slots[j, 0] == slots[j, 1] && slots[j, 1] == slots[j, 2])
                        {
                            isWin = true;
                            break;
                        }
                    }
                    
                }
                else if (choice == 3)

                    if ((slots[0, 0] == slots[1, 1] && slots[1, 1] == slots[2, 2]) ||

                        (slots[0, 2] == slots[1, 1] && slots[1, 1] == slots[2, 0]))
                    {
                        isWin = true;
                    }

                Console.WriteLine(isWin ? "\n Congratulations, you win!" : "\nTry again!");

            }

        }

    }

    



