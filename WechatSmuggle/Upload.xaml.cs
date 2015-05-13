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
using System.Windows.Shapes;

namespace WechatSmuggle
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        //private List<int> combolist = new List<int> { 1, 2, 3, 4, 5 };
        public Window3()
        {
            InitializeComponent();
            //this.cmbx.ItemsSource = combolist;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //开始备份按钮被点击
            String startDate;//需要传给localDBUpload，备份最近几天的文章
            int atclDays=0;
            bool invalidDay = false;
            if (rb_atclDays.IsChecked == true)
            {
                String str_atclDays = txbx_atclDays.Text;
                invalidDay = !int.TryParse(str_atclDays, out atclDays);
                startDate = DateTime.Now.AddDays(atclDays * (-1)).ToString("yyyy-MM-dd HH:mm:ss");
            }
            else {
                //startDate = getLastUpdatedDate();//获取最后一次更新时间
            }
            
            if (invalidDay)
            {
                MessageBoxResult result = MessageBox.Show("输入天数格式不正确，请输入大于0的数字", "", MessageBoxButton.OK);
            }
            else if (atclDays > 5) {
                String msg = "天数较多，可能会需要较长时间！！！\n确定备份最近" + atclDays + "天的文章？";
                MessageBoxResult result = MessageBox.Show(msg, "", MessageBoxButton.YesNo);
            }
            else{
                String msg = "确定备份最近" + atclDays + "天的文章?";
                MessageBoxResult result = MessageBox.Show(msg, "", MessageBoxButton.YesNo);
                ////需要传给localDBUpload，备份从startDate开始之后的文章
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //备份文章取消按钮被点击
            Application.Current.Shutdown();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //更新阅读数确认按钮被点击
            String startDate;//需要传给localDBUpload，备份最近几天的文章
            int readDays = 0;
            bool invalidDay = false;

            if (rb_readDays.IsChecked == true)
            {
                String str_readDays = txbx_readDays.Text;
                invalidDay = !int.TryParse(str_readDays, out readDays);
                startDate = DateTime.Now.AddDays(readDays * (-1)).ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                //startDate = getLastUpdatedDate();//获取最后一次更新时间
            }

            if (invalidDay)
            {
                MessageBoxResult result = MessageBox.Show("输入天数格式不正确，请输入大于0的数字", "", MessageBoxButton.OK);
            }
            else if (readDays > 5)
            {
                String msg = "天数较多，可能会需要较长时间！！！\n确定更新最近" + readDays + "的阅读量？";
                MessageBoxResult result = MessageBox.Show(msg, "", MessageBoxButton.YesNo);
            }
            else
            {
                String msg = "确定更新最近" + readDays + "天的阅读量?";
                MessageBoxResult result = MessageBox.Show(msg, "", MessageBoxButton.YesNo);
                ////需要传给localDBUpload，更新从startDate开始之后的阅读量
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //更新阅读数取消按钮被点击
            Application.Current.Shutdown();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //阅读数更新最近几天
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //输入的阅读数更新天数
        }
    }
}
