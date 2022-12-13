using ChessEngineWPF.Helpers;
using ChessEngineWPF.Models;
using ChessEngineWPF.Models.Pieces;
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

namespace ChessEngineWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Globals.Logger = new Logger();
            gMain.Children.Add(Globals.Logger.TextBlock);
            
            ChessBoard chessBoard = new ChessBoard();
            chessBoard.AddToGrid(ugChessBoard);

            King king = new King(PieceColor.White, new ChessSquare(0, 0));
            chessBoard.PlacePiece(king);

        }
    }
}
