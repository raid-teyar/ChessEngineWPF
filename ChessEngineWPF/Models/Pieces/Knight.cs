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
    public class Knight : Piece
    {
        public Knight(PieceColor color, ChessSquare square) : base(color, square)
        {
            Name = getPieceName();
            Weight = 3;
            FenNotation = color == PieceColor.White ? "N" : "n";
            ImageSource = ResourcesLoader.Load<ImageSource>(Name);
        }
    }
}
