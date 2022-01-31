using System;
using System.Collections.Generic;
using System.Text;

namespace tic_tac
{
    class Tictactoe
    {
        public char[] Board() 
        { 
            char[] Board = new char[10];
            for (int i = 1; i < Board.Length; i++)
            {
                Board[i] = ' ';
            }
            Console.WriteLine("Board initialized");
            return Board;
        }

        public char Player()
        {
            char[] choice = new char[] { 'X', 'O' };
            Console.WriteLine("Choose X or O ");
            char playerChoice = char.Parse(Console.ReadLine());
            if (playerChoice == choice[0])
            {
                playerChoice = choice[0];
            }
            else
            {
                playerChoice = choice[1];
            }
            return playerChoice;
        }
    }
}
