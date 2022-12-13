using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChessEngineWPF.Models.Pieces
{
    public class Piece
    {
        public PieceColor Color { get; set; }
        public ChessSquare Square { get; set; }
        public ImageSource ImageSource { get; set; }
        public int Weight { get; protected set; }
        public string FenNotation { get; protected set; }
        public string Name { get; protected set; }

        public Piece(PieceColor color, ChessSquare square)
        {
            Color = color;
            Square = square;
        }


        public override string ToString()
        {
            return string.Format("Color: {0}, Square: {1}", Color, Square);
        }

        public string getPieceName()
        {
            return Color + GetType().Name;
        }

    }
}
