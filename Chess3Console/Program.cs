// Zaripov Riyaz 220P Chess-3, 12.04.22

using System;
using Core;

namespace Chess3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(2, 1);
            knight.Move(1, 4);
            knight.Print();

            Queen queen = new Queen(1, 1);
            queen.Print();
            queen.Move("B2");
            queen.Print();

            Bishop bishop = new Bishop("C1");
            bishop.Move("D2");
            bishop.Move("E3");
            bishop.Move("D5");
            bishop.Print();

            King king = new King(4, 4);
            king.Move(5, 5);
            king.Print();
            king.Move(1, 1);
            king.Print();
        }
    }
}
