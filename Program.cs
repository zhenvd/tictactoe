using System;

namespace TicTacToe
{
    class Program
    {
        public static char[] arr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' }; //location marker
        public static char choice; //player inputs location to place mark
        static void Main(string[] args)
        {
           //2 players
           //ability to take turns -> loop?
           //somehow allow players to select space to place their mark -> maybe select a letter or number?
           //somehow create a board -> manually create it?
           //somehow update board with player selections of 'X' or 'O' -> console clear to update?
           //keep track of wins, losses, and draws -> counter
           //make sure to avoid placing 'X' or 'O' on spots already marked -> some kind of validation, thinking a do while with a try catch?
           //
        }
        public static void MakeBoard()
        {
            Console.WriteLine("     |     |     "); //5 spaces between each line
            Console.WriteLine("  {A}  |  {B}  |  {C}   ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {D}  |  {E}  |  {F}   ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {G}  |  {H}  |  {I}   ");
            Console.WriteLine("     |     |     ");
        }
    }
}
