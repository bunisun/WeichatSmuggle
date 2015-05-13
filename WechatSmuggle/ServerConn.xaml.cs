using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        String hostaddr, username, dbpswd, dbname;
        String connMsgHead = "测试链接：\n";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //测试链接按钮点击
            textbx_connMsg.Text = "";
            hostaddr = txbx_serverAddr.Text;
            username = txbx_username.Text;
            dbpswd = txbx_pswd.Text;
            dbname = txbx_dbname.Text;

            //检测服务器地址，用户名和密码是否输入
            if (hostaddr.Length * username.Length * dbpswd.Length == 0)
            {
                StringBuilder invalidInputsb = new StringBuilder(connMsgHead).Append("服务器地址，用户名和密码不能为空！");
                textbx_connMsg.Text = invalidInputsb.ToString();

            }else if(false/*onnectionFailed*/){
                StringBuilder invalidInputsb = new StringBuilder(connMsgHead).Append("不能连接到服务器，再次检查地址用户名和密码正确");
                textbx_connMsg.Text = invalidInputsb.ToString();
            }
            else { 
                //显示连接状态
                //codes here


                //记录服务器连接信息，发送给LocalDBUpload
                //codes here
                
                //跳转db界面
                StringBuilder invalidInputsb = new StringBuilder(connMsgHead).Append("连接成功！");
                MessageBoxResult result = MessageBox.Show(invalidInputsb.ToString(),"", MessageBoxButton.OK);
                
                MainWindow mwind = new MainWindow();
                mwind.Show();
                this.Close();
            }
        }

        private void textbx_connMsg_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //server address textbox
        }

        private void txbx_username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txbx_pswd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txbx_dbname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
