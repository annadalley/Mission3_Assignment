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
            bool spotTaken = false;
            string[] board = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            Console.WriteLine("Welcome to Tic Tac Toe!");

            while (winner == "n") 
            {
                sc.PrintBoard(board);

                do
                {
                    Console.WriteLine("\nWhere would Player 1 like to place an X?");
                    choice1 = Console.ReadLine();

                    if (board[Convert.ToInt32(choice1) - 1] == "O" | board[Convert.ToInt32(choice1) - 1] == "X")
                    {
                        Console.WriteLine("\nThat spot is already taken\n");
                        spotTaken = true;
                    }
                    else
                    {
                        spotTaken = false;

                        for (int i = 0; i < board.Length; i++)
                        {
                            if (board[i] == choice1)
                            {
                                board[i] = "X";
                            }
                        }
                    }
                } while (spotTaken == true);


                winner = sc.CheckForWinner(board);
                if (winner == "n")
                {
                    sc.PrintBoard(board);

                    do
                    {
                        Console.WriteLine("\nWhere would Player 2 like to place an O?");
                        choice2 = Console.ReadLine();

                        if (board[Convert.ToInt32(choice2) - 1] == "O" | board[Convert.ToInt32(choice2) - 1] == "X")
                        {
                            Console.WriteLine("\nThat spot is already taken\n");
                            spotTaken = true;
                        }
                        else
                        {
                            spotTaken = false;

                            for (int i = 0; i < board.Length; i++)
                            {
                                if (board[i] == choice2)
                                {
                                    board[i] = "O";
                                }
                            }
                        }
                    } while (spotTaken == true);

                    winner = sc.CheckForWinner(board);
                }
            }
            sc.PrintBoard(board);
        }
    }
}
