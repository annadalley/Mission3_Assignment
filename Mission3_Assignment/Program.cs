using System;

namespace Mission3_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            SupportingClass sc = new SupportingClass();
            string choice1 = "";
            string choice2 = "";
            string winner = "n";
            string[] board = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            Console.WriteLine("Welcome to Tic Tac Toe!");

            while (winner == "n") 
            {
                sc.PrintBoard(board);

                Console.WriteLine("Where would Player 1 like to place an X?");
                choice1 = Console.ReadLine();


                for (int i = 0; i < 9; i++)
                {
                    if (board[i] == choice1)
                    {
                        board[i] = "X";
                    }
                }

                winner = sc.CheckForWinner(board);
                if (winner == "n")
                {
                    sc.PrintBoard(board);
                    Console.WriteLine("\n\nWhere would Player 2 like to place an O?");
                    choice2 = Console.ReadLine();
                    for (int i = 0; i < 9; i++)
                    {
                        if (board[i] == choice2)
                        {
                            board[i] = "O";
                        }
                    }
                    winner = sc.CheckForWinner(board);
                }
            }
            sc.PrintBoard(board);
        }
    }
}
