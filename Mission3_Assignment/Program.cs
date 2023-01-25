using System;

namespace Mission3_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice1 = "";
            string choice2 = ""
            string[] board = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            Console.WriteLine("Welcome to Tic Tac Toe!");

            //Player 1 goes, Player 2 goes, Loop.
            Console.WriteLine("Where would Player 1 like to place an X?");
            choice1 = Console.ReadLine();
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == choice1)
                {
                    board[i] = "X";
                }
            }

            // 
            Console.WriteLine("Where would Player 2 like to place an O?");
            choice2 = Console.ReadLine();
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == choice2)
                {
                    board[i] = "O";
                }
            }
        }
    }
}
