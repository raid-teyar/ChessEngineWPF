using ChessEngineWPF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ChessEngineWPF.Models.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(PieceColor color, ChessSquare square) : base(color, square)
        {
            Name = getPieceName();
            Weight = 3;
            FenNotation = color == PieceColor.White ? "B" : "b";
            ImageSource = ResourcesLoader.Load<ImageSource>(Name);
        }
    }
}
