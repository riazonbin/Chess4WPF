// Zaripov Riyaz 220P Chess-3, 12.04.22

using System;

namespace Chess3Console
{
    public class Knight : Piece
    {
        public Knight(string cell) : base(cell)
        {
        }

        public Knight(int x, int y) : base(x, y)
        {
        }

        private protected override bool IsRightMove(int x, int y)
        {
            return Math.Abs(this.x - x) == 1 && Math.Abs(this.y - y) == 2
                || Math.Abs(this.x - x) == 2 && Math.Abs(this.y - y) == 1;
        }
    }
}
