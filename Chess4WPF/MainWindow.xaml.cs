// Zaripov Riyaz 220P Chess-4, 14.06.22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Core;
using System.Xaml;

namespace Chess4WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string chosenPiece;
        private Piece piece;
        private bool figureisSet;
        private Button lastButton;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int row = GetRow(sender);
            int column = GetColumn(sender);

            if (figureisSet)
            {
                if(piece.Move(row, column))
                {
                    lastButton.Content = "";
                    lastButton = (sender as Button);
                    lastButton.Content = chosenPiece;
                }
                return;
            }

            try 
            {
                (sender as Button).Content = chosenPiece;
                piece = PieceFactory.MakePiece(chosenPiece, row, column);
                figureisSet = true;

                lastButton = (sender as Button);
            }
            catch
            {
            }
        }

        private void PiecesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(chosenPiece))
            {
                switch ((sender as MenuItem).Header)
                {
                    case "King":
                        chosenPiece = "King";
                        break;

                    case "Queen":
                        chosenPiece = "Queen";
                        break;

                    case "Rook":
                        chosenPiece = "Rook";
                        break;

                    case "Knight":
                        chosenPiece = "Knight";
                        break;

                    case "Bishop":
                        chosenPiece = "Bishop";
                        break;

                }
            }
            else
            {
                MessageBox.Show("Clear the desk to set new piece!");
            }

        }

        private void ClearDeskMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var buttons = mainGrid.Children.OfType<Button>().ToList();

            foreach(var button in buttons)
            {
                button.Content = "";
            }
            figureisSet = false;
            chosenPiece = "";
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if(!figureisSet || (sender as Button).Content != "")
            {
                return;
            }

            int row = GetRow(sender);
            int column = GetColumn(sender);

            (sender as Button).Content = piece.TryMove(row, column) ? "YES" : "NO";
        }

        private int GetRow(object sender)
        {
            int row = Grid.GetRow(sender as Button);
            return row;
        }

        private int GetColumn(object sender)
        {
            int column = Grid.GetColumn(sender as Button);
            return column;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            if(figureisSet && GetRow(sender) == piece.GetXCoord() 
                && GetColumn(sender) == piece.GetYCoord())
            {
                return;
            }
            (sender as Button).Content = "";
        }
    }
}
