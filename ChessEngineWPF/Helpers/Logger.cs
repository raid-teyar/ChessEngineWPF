using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChessEngineWPF.Helpers
{
    public class Logger
    {
        public TextBlock TextBlock { get; set; }

        public Logger()
        {
            TextBlock = new TextBlock();
            ClearEach5Seconds();
        }

        public void Log(string message)
        {
            TextBlock.Text += message + Environment.NewLine;
        }

        public void Log(string message, params object[] args)
        {
            Log(string.Format(message, args));
        }


        public void Clear()
        {
            TextBlock.Text = string.Empty;
        }

        public void ClearEach5Seconds()
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Task.Delay(5000).Wait();
                     ClearIfNecessary();
                }
            });
        }

        public void ClearIfNecessary()
        {
            if (TextBlock.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length > 10)
            {
                Clear();
            }
        }
    }

}
