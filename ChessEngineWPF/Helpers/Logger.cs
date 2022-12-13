using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ChessEngineWPF.Helpers
{
    public class Logger
    {
        public TextBlock TextBlock { get; set; }
        public Timer Timer { get; set; }

        public Logger()
        {
            TextBlock = new TextBlock()
            {
                TextWrapping = TextWrapping.Wrap,
                FontSize = 12,
                Margin = new System.Windows.Thickness(10, 10, 10, 10)
            };
            
            Timer = new Timer(UpdateTextBlock, null, 0, 1000);
        }

        private void UpdateTextBlock(object? state)
        {
            // run on ui thread
            TextBlock.Dispatcher.Invoke(() =>
            {
                if (TextBlock.Inlines.Count > 10)
                {
                    TextBlock.Inlines.Remove(TextBlock.Inlines.FirstInline);

                    TextBlock.UpdateLayout();
                }
            });
        }

        public void Log(string message)
        {
            // add new inline to textblock
            TextBlock.Dispatcher.Invoke(() =>
            {
                TextBlock.Inlines.Add(new Run(message + Environment.NewLine));
                TextBlock.UpdateLayout();
            });
        }

        public void Log(string message, params object[] args)
        {
            Log(string.Format(message, args));
        }

        public void Clear()
        {
            TextBlock.Text = string.Empty;
        }

        public void ClearLine()
        {
            TextBlock.Text = TextBlock.Text.Substring(0, TextBlock.Text.LastIndexOf(Environment.NewLine));
        }
    }

}
