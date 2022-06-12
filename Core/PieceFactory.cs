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
            Piece piece;

            switch (pieceCode)
            {
                case "K":
                case "k":
                case "King":
                    piece = new King(coords1);
                    break;

                case "B":
                case "b":
                case "Bishop":
                    piece = new Bishop(coords1);
                    break;

                case "N":
                case "n":
                case "Knight":
                    piece = new Knight(coords1);
                    break;

                case "Q":
                case "q":
                case "Queen":
                    piece = new Queen(coords1);
                    break;

                case "R":
                case "r":
                case "Rook":
                    piece = new Rook(coords1);
                    break;

                default: throw new Exception("Unknown figure");
            }

            return piece;
        }
    }
}
