using ChessEngineWPF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ChessEngineWPF.Models.Pieces
{
    public class King : Piece
    {
        public King(PieceColor color, ChessSquare square) : base(color, square)
        {
            Name = getPieceName();
            Weight = 1000;
            FenNotation = color == PieceColor.White ? "K" : "k";
            ImageSource = ResourcesLoader.Load<ImageSource>(Name);
        }
    }
}
