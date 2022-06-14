// Zaripov Riyaz 220P Chess-4, 14.06.22

using System;

namespace Core
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
