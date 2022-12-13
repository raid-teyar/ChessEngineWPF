using ChessEngineWPF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;
using System.Windows.Media.Media3D;
using System.Windows.Media;
using System.Xml.Linq;

namespace ChessEngineWPF.Models.Pieces
{
    public class Rook : Piece
    {
        public Rook(PieceColor color, ChessSquare square) : base(color, square)
        {
            Name = getPieceName();
            Weight = 5;
            FenNotation = color == PieceColor.White ? "R" : "r";
            ImageSource = ResourcesLoader.Load<ImageSource>(Name);
        }
    }
}
