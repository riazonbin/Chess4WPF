// Zaripov Riyaz 220P Chess-4, 14.06.22

using System;
using Core;

namespace Chess3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string pieceCode = Console.ReadLine();
                string coords1 = Console.ReadLine();
                string coords2 = Console.ReadLine();

                try
                {
                    Piece piece = PieceFactory.MakePiece(pieceCode, coords1);
                    Console.WriteLine(piece.Move(coords2) ? "YES" : "NO");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
