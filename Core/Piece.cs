// Zaripov Riyaz 220P Chess-4, 14.06.22

using System;
using System.Collections.Generic;

namespace Core
{
    public abstract class Piece
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

        public bool Move(string moveStr)
        {
            int newX = charToIntCoords[moveStr[0]];
            int newY = int.Parse(moveStr[1].ToString());

            if(newX > 8 || newX < 1 || newY > 9 || newY < 1)
            {
                throw new Exception("Border is 8x8 cells!!!");
            }

            if (IsRightMove(newX, newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            return false;
        }

        public bool Move(int x, int y)
        {
            if (x > 8 || x < 1 || y > 9 || y < 1)
            {
                throw new Exception("Border is 8x8 cells!!!");
            }

            if (IsRightMove(x, y))
            {
                this.x = x;
                this.y = y;
                return true;
            }
            return false;
        }

        public bool TryMove(int x, int y)
        {
            if (x > 8 || x < 1 || y > 9 || y < 1)
            {
                throw new Exception("Border is 8x8 cells!!!");
            }

            if (IsRightMove(x, y))
            {
                return true;
            }
            return false;
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

        public int GetXCoord()
        {
            return x;
        }
        public int GetYCoord()
        {
            return y;
        }
    }
}