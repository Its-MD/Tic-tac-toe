using System;
namespace X_and_O_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Field field = new();
            char player;
            int numRow, numCol;
            for (int i = 0; i < 9; i++)
            {
                player = i % 2 == 0 ? 'X' : 'O';
                Console.WriteLine($"Currently playing: {player}");
                Console.WriteLine("Input number of row");
                numRow = int.Parse(Console.ReadLine());
                Console.WriteLine("Input number of colomn");
                numCol = int.Parse(Console.ReadLine());
                if (field.ChoiceCheck(numRow, numCol))
                {
                    field.FillInChoice(numRow, numCol, player);
                    if (field.GameResult(player))
                    {
                        Console.WriteLine($"Player {player} has won.");
                        break;
                    }
                }
                else
                {
                    i--;
                }
            }
        }
    }
}