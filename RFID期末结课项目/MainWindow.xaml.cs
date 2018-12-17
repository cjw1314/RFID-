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
using MySql.Data.MySqlClient;
namespace RFID期末结课项目
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*登录界面隐藏函数*/
        private void Login_hidden()
        {
            Label_Title.Visibility = Visibility.Hidden;
            GB_Login.Visibility = Visibility.Hidden;
        }

        /*登录界面显示函数*/
        private void Login_show()
        {
            Label_Title.Visibility = Visibility.Visible;
            GB_Login.Visibility = Visibility.Visible;
        }

        /*登录按钮*/
        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {

            if(TextBox_Account.Text=="cjw"&&TextBox_Password.Text=="1")
            {
                MessageBox.Show("登录成功！");
                Login_hidden();
            }
           else
            {
                if(TextBox_Account.Text == "" || TextBox_Password.Text == "")
                    MessageBox.Show("登录失败，账号或密码不能为空");
                else
                MessageBox.Show("登录失败，账号或密码错误");
            }
        }



        /*窗口被加载*/
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Width = 850;
            this.Height = 555;
        }
    }
}
