// Zaripov Riyaz 220P Chess-3, 12.04.22

using System;

namespace Chess3Console
{
    public class Rook : Piece
    {
        public Rook(string cell) : base(cell)
        {
        }

        public Rook(int x, int y) : base(x, y)
        {
        }

        private protected override bool IsRightMove(int x, int y)
        {
            return this.x == x || this.y == y;
        }
    }
}
