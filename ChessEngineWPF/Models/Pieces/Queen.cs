using ChessEngineWPF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ChessEngineWPF.Models.Pieces
{
    public class Queen : Piece
    {
        public Queen(PieceColor color, ChessSquare square) : base(color, square)
        {
            Name = getPieceName();
            Weight = 9;
            FenNotation = color == PieceColor.White ? "Q" : "q";
            ImageSource = ResourcesLoader.Load<ImageSource>(Name);
        }
    }
}
