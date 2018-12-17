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
using ISO14443DLL;
namespace RFID期末结课项目
{
    /// <summary>
    /// MainFunction.xaml 的交互逻辑
    /// </summary>
    public partial class MainFunction : Window
    {

        public MainFunction()
        {
            ISO14443DLL.ISO14443Reader reader = new ISO14443Reader();
            InitializeComponent();

        }
    }
}
