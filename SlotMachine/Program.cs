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
            int[,] slotMachine2 = new int[ROWS, COLUMNS];
            int[,] slotMachine3 = new int[ROWS, COLUMNS];
            
            int[,] slots = new int[ROWS, COLUMNS];

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
                    Console.Write(slotMachine2[i, j]);
                }

                Console.WriteLine();
            }
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    slotMachine3[i, j] = rng.Next(LOW_NUMBER, HIGH_NUMBER);
                }
            }
            Console.WriteLine();
            
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    Console.Write(slotMachine[i, j]);
                }
               
                Console.WriteLine();
                
            }
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    slotMachine2[i, j] = rng.Next(LOW_NUMBER, HIGH_NUMBER);
                }
            }
            Console.WriteLine();
            
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    Console.Write(slotMachine3[i, j]);
                }
                Console.Write(slots[i, j].ToString().PadLeft(4));
            }
            bool isWin = false;
            for (int i = 0; i < COLUMNS; i++)
            {
                if (slotMachine[i, 0] == slotMachine[i, 1] && slotMachine[i, 1] == slotMachine[i, 2])
                {

                }
                bool isWin2 = true;
                for (int j = 0; j < COLUMNS; j++)
                {
                    if (slotMachine2[j, 0] == slotMachine2[j, 1] && slotMachine2[j, 1] == slotMachine2[j, 2])
                    {

                        for (int k = 0; k < COLUMNS; k++)
                            if (slotMachine3[k, 0] == slotMachine3[k, 1] && slotMachine3[k, 1] == slotMachine3[k, 2])
                            {
                                isWin = true;
                                break;
                            }
                    }
                    if (slots[i, j] % 2 == 0)
                    {
                        Console.Write(slotMachine.PadLeft(4));
                    }
                    else if(isWin2)
                    {
                        Console.Write(slotMachine2.PadLeft(4));
                    }
                    else 
                    {
                        Console.Write(slotMachine3.PadLeft(4));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(isWin ? "Congratulations, you win!" : "Try again!");
                    break;
            }
        }
    } }
}

