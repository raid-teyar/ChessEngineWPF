using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChessEngineWPF.Helpers
{
    public static class ResourcesLoader
    {
        public static T Load<T>(string resourceName)
        {
            return (T) Application.Current.FindResource(resourceName);
        }
    }
}
