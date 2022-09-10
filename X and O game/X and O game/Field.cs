using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_and_O_game
{
    internal class Field
    {
        char[,] Symbols = new char[3,3];
        public Field()
        {
            Fill();
            Print();
        }
        public void Fill()
        {
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Symbols[i, j] = '_';
                }
            }
        }
        public void Print()
        {
            for (int i=0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(Symbols[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void FillInChoice(int numRow, int numCol, char symbTurn)
        {
            Symbols[numRow, numCol] = symbTurn;
            Print();
        }
        public bool ChoiceCheck(int numRow, int numCol)
        {
            if(numRow < 0 || numRow > 2 || numCol < 0 || numCol > 2)
            {
                Console.WriteLine("Invalid field, try again.");
                return false;
            }
            if(Symbols[numRow, numCol] != '_')
            {
                Console.WriteLine("The field is occupied, choose a different one.");
                return false;
            }
            return true;
        }
        public bool GameResult(char symbTurn)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Symbols[0, i] == symbTurn && Symbols[1, i] == symbTurn && Symbols[2, i] == symbTurn) {
                    return true;
                }
                if (Symbols[i, 0] == symbTurn && Symbols[i, 1] == symbTurn && Symbols[2, i] == symbTurn) {
                    return true;
                }
            }
            if (Symbols[0, 0] == symbTurn && Symbols[1, 1] == symbTurn && Symbols[2, 2] == symbTurn)
            {
                return true;
            }
            return Symbols[0, 2] == symbTurn && Symbols[1, 1] == symbTurn && Symbols[2, 0] == symbTurn;
        }
    }
}