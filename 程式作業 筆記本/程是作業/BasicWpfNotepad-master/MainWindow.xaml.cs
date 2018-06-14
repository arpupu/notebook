using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicWpfNotepad
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = "";

        public MainWindow()
        {
            InitializeComponent();
        }


        


        

     

        private void OPENbtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 產生開啟檔案視窗 OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // 顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

            // 當按下開啟之後的反應 
            if (result == true)
            {
                // 取得檔案路徑 
                filePath = dlg.FileName;

                // 讀取檔案
                TextArea.Text = System.IO.File.ReadAllText(filePath);
            }
        }

        private void SAVEbtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 產生開啟檔案視窗 OpenFileDialog 
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

            // 顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

            // 當按下開啟之後的反應 
            if (result == true)
            {
                // 取得檔案路徑 
                filePath = dlg.FileName;

                // 儲存檔案
                System.IO.File.WriteAllText(filePath, TextArea.Text);
            }
        }

        private void SAVEASbtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

            // 顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

   
        }

        private void NEWbtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextArea.Text = "";
        }

        private void whiteellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextArea.Background = Brushes.Black;
            TextArea.Foreground = Brushes.White;
        }

        private void blackellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextArea.Background = Brushes.Gray;
            TextArea.Foreground = Brushes.Black;
        }

        private void little_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextArea.FontSize = 15;
        }

        private void middle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextArea.FontSize = 25;
        }

        private void big_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextArea.FontSize = 35;
        }
    }
}
