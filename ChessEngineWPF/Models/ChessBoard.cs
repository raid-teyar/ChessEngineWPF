using ChessEngineWPF.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace ChessEngineWPF.Models
{
    public class ChessBoard
    {
        private readonly Style lightSquare;
        private readonly Style darkSquare;

        public List<ChessSquare> ChessSquares { get; set; } 

        public ChessBoard()
        {
            lightSquare = (Style) Application.Current.TryFindResource("lightSquare");
            darkSquare = (Style) Application.Current.TryFindResource("darkSquare");
            
            ChessSquares = new List<ChessSquare>();

            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    ChessSquare square = new ChessSquare(row, column);
                    square.Style = (row + column) % 2 == 0 ? lightSquare : darkSquare;
                    square.Row = row;
                    square.Column = column;
                    ChessSquares.Add(square);
                }
            }
        }

        public void AddToGrid(UniformGrid grid)
        {
            foreach (ChessSquare square in ChessSquares)
            {
                grid.Children.Add(square);
            }
        }

        public void PlacePiece(Piece piece)
        {
            ChessSquare? square = ChessSquares.Find(s => s.Row == piece.Square.Row && s.Column == piece.Square.Column);
            square.Piece = piece;
            UpdateBoard();
        }

        // needs optimizations later
        public void UpdateBoard()
        {
            foreach (ChessSquare square in ChessSquares)
            {
                square.UpdateSquare();
            }
        }
    }
}
