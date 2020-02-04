using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Waf.MusicManager.Presentation.Helper
{
    class FocusElement
    {
        public static void FocusPlayList()
        {
            if (Application.Current.MainWindow != null)
            {
                var listboxContent = Application.Current.MainWindow.FindName("listboxContent");
                var myTextBlock = FindElement.FindElementByName<ListBox>((DependencyObject)listboxContent, "playlistListBox");
                myTextBlock.Focus();
            }
        }
    }
}
