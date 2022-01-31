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
    }
}
