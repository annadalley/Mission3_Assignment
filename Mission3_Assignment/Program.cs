using System;

namespace Mission3_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice1 = " ";
            string[,] board = new string[,] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

            Console.WriteLine("Welcome to Tic Tac Toe!");

            Console.WriteLine(board[0, 0]);
            Console.WriteLine(board[0, 1]);
            Console.WriteLine(board[0, 2]);
            Console.WriteLine(board[1, 0]);
            Console.WriteLine(board[1, 1]);
            Console.WriteLine(board[1, 2]);
            Console.WriteLine(board[2, 0]);
            Console.WriteLine(board[2, 1]);
            Console.WriteLine(board[2, 2]);




            //Player 1 goes, Player 2 goes, Loop.
            Console.WriteLine("Where would player 1 like to place an X? ");
            choice1 = Console.ReadLine();
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    if (choice1 == board[i, j])
                    {
                        board[i, j] = "X";
                    }
                }
            }

            Console.WriteLine(board[0, 0]);
            Console.WriteLine(board[0, 1]);
            Console.WriteLine(board[0, 2]);
            Console.WriteLine(board[1, 0]);
            Console.WriteLine(board[1, 1]);
            Console.WriteLine(board[1, 2]);
            Console.WriteLine(board[2, 0]);
            Console.WriteLine(board[2, 1]);
            Console.WriteLine(board[2, 2]);



        }
    }
}
