using System;

namespace Mission3_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            SupportingClass sc = new SupportingClass();
            string choice1 = "";
            string choice2 = "";
            string winner = "n";
            bool spotTaken = false;
            string[] board = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            // print welcome
            Console.WriteLine("Welcome to Tic Tac Toe!");

            // while there is no winner, print the board, ask the first user where they would like to go, if that spot hasn't already been taken, fill in the spot. If it has, make them pick another spot.
            while (winner == "n")
            {
                sc.PrintBoard(board);

                do
                {
                    Console.WriteLine("\nWhere would Player X like to place an X?");
                    choice1 = Console.ReadLine();

                    if (board[Convert.ToInt32(choice1) - 1] == "O" | board[Convert.ToInt32(choice1) - 1] == "X")
                    {
                        Console.WriteLine("\nThat spot is already taken");
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


                // if there's still no winner, print the updated board, ask the 2nd user where they want to go, if that spot hasn't already been taken, fill in the spot. If it has, make them pick another spot.
                winner = sc.CheckForWinner(board);
                if (winner == "n")
                {
                    sc.PrintBoard(board);

                    do
                    {
                        Console.WriteLine("\nWhere would Player O like to place an O?");
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

                    // check to see if there is another winner
                    winner = sc.CheckForWinner(board);
                }
            }
            // print the board
            sc.PrintBoard(board);
        }
    }
}