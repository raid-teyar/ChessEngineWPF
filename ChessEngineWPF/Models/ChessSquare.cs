using ChessEngineWPF.Helpers;
using ChessEngineWPF.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ChessEngineWPF.Models
{
    public class ChessSquare : Label
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public Piece Piece { get; set; }

        public ChessSquare(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public override string ToString()
        {
            return string.Format("Row: {0}, Column: {1}", Row, Column);
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            ChessSquare source = (ChessSquare)e.Source;
            Globals.Logger.Log("Clicked square: " + source.ToString() + " with piece: " + source.Piece?.Name);
        }

        public void UpdateSquare()
        {
            if (Piece != null)
            {
                AddChild(new Image{ Source = Piece.ImageSource});
            }
            else
            {
                Content = null;
            }
        }
    }
}
