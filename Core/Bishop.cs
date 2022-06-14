// Zarip// Zaripov Riyaz 220P Chess-4, 14.06.22

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
