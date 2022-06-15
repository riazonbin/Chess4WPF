// Zaripov Riyaz 220P Chess-3, 12.04.22

using System;

namespace Chess3Console
{
    public class Queen : Piece
    {
        public Queen(string cell) : base(cell)
        {
        }

        public Queen(int x, int y) : base(x, y)
        {
        }

        private protected override bool IsRightMove(int x, int y)
        {
            int xMovement = Math.Abs(this.x - x);
            int yMovement = Math.Abs(this.y - y);

            string coords1 = $"{this.x}{this.y}";
            string coords2 = $"{x}{y}";

            return (xMovement == yMovement || xMovement == 0 || yMovement == 0)
                    && coords1 != coords2;
        }
    }
}
