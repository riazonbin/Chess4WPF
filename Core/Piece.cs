// Zaripov Riyaz 220P Chess-3, 12.04.22

using System;
using System.Collections.Generic;

namespace Core
{
    public class Piece
    {
        protected int x;
        protected int y;

        public Piece(string cell)
        {
            x = charToIntCoords[cell[0]];
            y = int.Parse(cell[1].ToString());
        }

        public Piece(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(string moveStr)
        {
            int newX = charToIntCoords[moveStr[0]];
            int newY = int.Parse(moveStr[1].ToString());

            if (IsRightMove(newX, newY))
            {
                x = newX;
                y = newY;
            }
            else
            {
                Console.WriteLine($"Wrong move for the {GetType().Name}");
            }
        }

        public void Move(int x, int y)
        {
            if (IsRightMove(x, y))
            {
                this.x = x;
                this.y = y;
            }
            else
            {
                Console.WriteLine($"Wrong move for the {GetType().Name}");
            }
        }

        virtual private protected bool IsRightMove(int x, int y)
        {
            return true;
        }

        protected Dictionary<char, int> charToIntCoords = new Dictionary<char, int>
        {
            {'A', 1 },
            {'B', 2 },
            {'C', 3 },
            {'D', 4 },
            {'E', 5 },
            {'F', 6 },
            {'G', 7 },
            {'H', 7 }
        };

        protected Dictionary<int, char> intToCharCoords = new Dictionary<int, char>
        {
            {1, 'A' },
            {2, 'B' },
            {3, 'C' },
            {4, 'D' },
            {5, 'E' },
            {6, 'F' },
            {7, 'G' },
            {8, 'H' }
        };

        public void Print()
        {
            Console.WriteLine($"{GetType().Name} is located on {intToCharCoords[x].ToString() + y}");
        }
    }
}