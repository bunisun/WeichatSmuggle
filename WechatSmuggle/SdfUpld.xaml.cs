using Microsoft.Win32;
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

namespace WechatSmuggle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sdfdir_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_browse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new Microsoft.Win32.OpenFileDialog();
            //op.InitialDirectory = lblSavePath.Text;//默认的打开路径
            op.RestoreDirectory = true;
            op.Filter = " 数据库文件(*.sdf)|*.sdf";
            op.ShowDialog();
            text_sdfDir.Text = op.FileName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //点击取消按钮，退出程序
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //点击确认按钮，确认上传数据库文件
            String dbdir = text_sdfDir.Text;
            if (dbdir.Length==0||!dbdir.EndsWith("sdf"))
            {
                lbl_warning.Visibility = Visibility.Visible;
            }
            else {
                //sdf路径传值给localdbupload
                lbl_warning.Visibility = System.Windows.Visibility.Hidden;
            }
        }
    }
}
