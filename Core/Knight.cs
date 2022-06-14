// Zaripov Riyaz 220P Chess-4, 14.06.22

using System;

namespace Core
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
