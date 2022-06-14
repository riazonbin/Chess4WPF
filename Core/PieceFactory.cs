// Zaripov Riyaz 220P Chess-4, 14.06.22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class PieceFactory
    {
        public static Piece MakePiece(string pieceCode, string coords1)
        {
            int x1 = coords1[0];
            int y1 = coords1[1];

            return MakePiece(pieceCode, x1, y1);

        }


        public static Piece MakePiece(string pieceCode, int x1, int y1)
        {
            Piece piece;

            switch (pieceCode)
            {
                case "K":
                case "k":
                case "King":
                    piece = new King(x1, y1);
                    break;

                case "B":
                case "b":
                case "Bishop":
                    piece = new Bishop(x1, y1);
                    break;

                case "N":
                case "n":
                case "Knight":
                    piece = new Knight(x1, y1);
                    break;

                case "Q":
                case "q":
                case "Queen":
                    piece = new Queen(x1, y1);
                    break;

                case "R":
                case "r":
                case "Rook":
                    piece = new Rook(x1, y1);
                    break;

                default: throw new Exception("Unknown figure");
            }

            return piece;
        }
    }
}
