using ChessEngineWPF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ChessEngineWPF.Models.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(PieceColor color, ChessSquare square) : base(color, square)
        {
            Name = getPieceName();
            Weight = 1;
            FenNotation = color == PieceColor.White ? "P" : "p";
            ImageSource = ResourcesLoader.Load<ImageSource>(Name);
        }
    }
}
