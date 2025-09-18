// See https://aka.ms/new-console-template for more information
using System;

using System;
using System.ComponentModel;
using System.Data;
using System.Net;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bigLoop = false;
            for (int o = 0; o < 3; o++)
            {
                Random rng = new Random();
                const int LOWER_NUMBER = 3;
                const int HIGHER_NUMBER = 3;
                int ROWS = rng.Next(LOWER_NUMBER, HIGHER_NUMBER);
                int COLUMNS = rng.Next(LOWER_NUMBER, HIGHER_NUMBER);
                const int LOW_NUMBER = 1;
                const int HIGH_NUMBER = 4;
                const string RUN_AGAIN = "Y";
                

                const int HORIZONTAL_MODE = 1;
                const int VERTICAL_MODE = 2;
                const int DIAGONAL_MODE = 3;
                
                
                int[,] slots = new int[ROWS, COLUMNS];

                Console.WriteLine("Please play the Slot Machine");
                Console.WriteLine($"Press {HORIZONTAL_MODE} for horizontal win");
                Console.WriteLine($"Press {VERTICAL_MODE} for vertical win");
                Console.WriteLine($"Press {DIAGONAL_MODE} for diagonal win");
                int choice = int.Parse(Console.ReadLine());


                {
                    if (choice != HORIZONTAL_MODE && choice != VERTICAL_MODE && choice != DIAGONAL_MODE)
                        Console.WriteLine("Do user input until choice is valid.");
                    {

                        {
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
                            
                            if (choice == HORIZONTAL_MODE)

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
                            else if (choice == VERTICAL_MODE)
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
                            else if (choice == DIAGONAL_MODE)
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
                                    Console.WriteLine("🎉 Congratulations, you win!");
                                }

                                if (mainDiagonalWin || antiDiagonalWin)
                                {
                                    isWin = false;
                                }
                                Console.Write("Enter Money:");
                                int Money = Console.Read();
                                while (Money < 50)
                                {
                                    Console.WriteLine($"Current cash value: {Money}");
                                    Money--; 
                                }
                                if (Money > 1)
                                    Console.WriteLine($"${Money-8}");
                            }
                            Console.WriteLine("Sorry, you  don't win!");
                            Console.Write($"Do you want to run again? Press {RUN_AGAIN}" + "     ");
                            Console.ReadLine();
                        }
                    }
                }
            } //test 
        }
    }
}

    
        

    


        







    



