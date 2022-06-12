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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(figureisSet)
            {
                return;
            }

            (sender as Button).Content = chosenPiece;

            int row = GetRow(sender);
            int column = GetColumn(sender);

            piece = PieceFactory.MakePiece(chosenPiece, row, column);

            figureisSet = true;
        }

        private void PiecesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            switch((sender as MenuItem).Header)
            {
                case "King": chosenPiece = "King";
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
            if(figureisSet && (sender as Button).Content == "")
            {
                int row = GetRow(sender);
                int column = GetColumn(sender);

                (sender as Button).Content = piece.Move(row, column) ? "YES" : "NO";
            }
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
    }
}
