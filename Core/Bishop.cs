// Zaripov Riyaz 220P Chess-3, 12.04.22

using Chess3Console;
using System;

namespace Core
{
    public class Bishop : Piece
    {
        public Bishop(string cell) : base(cell)
        {
        }

        public Bishop(int x, int y) : base(x, y)
        {
        }

        private protected override bool IsRightMove(int x, int y)
        {
            return Math.Abs(this.x - x) == Math.Abs(this.y - y);
        }
    }
}
