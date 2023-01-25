using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;





namespace Mission3_Assignment
{
    public class SupportingClass
    {
        public void PrintBoard(string[] boardArray)
        {
            Console.WriteLine(boardArray[0] + " | " + boardArray[1] + " | " + boardArray[2]);
            Console.WriteLine("---------");
            Console.WriteLine(boardArray[3] + " | " + boardArray[4] + " | " + boardArray[5]);
            Console.WriteLine("---------");
            Console.WriteLine(boardArray[6] + " | " + boardArray[7] + " | " + boardArray[8]);
        }

        public string CheckForWinner(string[] boardArray)
        {
            string winner = "n";

            // 1, 2, 3 horizontal top row
            if (boardArray[0] == boardArray[1] && boardArray[1] == boardArray[2])
            {
                winner = boardArray[0];
            }

            else if (boardArray[3] == boardArray[4] && boardArray[4] == boardArray[5])
            {
                winner = boardArray[3];
            }

            else if (boardArray[6] == boardArray[7] && boardArray[7] == boardArray[8])
            {
                winner = boardArray[6];
            }

            else if (boardArray[0] == boardArray[3] && boardArray[3] == boardArray[6])
            {
                winner = boardArray[0];
            }

            else if (boardArray[1] == boardArray[4] && boardArray[4] == boardArray[7])
            {
                winner = boardArray[1];
            }

            else if (boardArray[2] == boardArray[5] && boardArray[5] == boardArray[8])
            {
                winner = boardArray[2];
            }

            else if (boardArray[0] == boardArray[4] && boardArray[4] == boardArray[8])
            {
                winner = boardArray[0];
            }

            else if (boardArray[2] == boardArray[4] && boardArray[4] == boardArray[6])
            {
                winner = boardArray[2];
            }

            else if (boardArray[0] != "1" && boardArray[1] != "2" && boardArray[2] != "3" && boardArray[3] != "4" && boardArray[4] != "5" && boardArray[5] != "6" && boardArray[6] != "7" && boardArray[7] != "8" && boardArray[8] != "9")
            {
                Console.WriteLine("It's a Tie!");
            }

            if (winner != "n")
            {
                Console.WriteLine("Player " + winner + " wins!");
            }
            return winner;
        }
    }
}