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

namespace LogPas
{
    public partial class MainWindow : Window
    {
        private string _login;
        private string _password;
        public MainWindow()
        {
            InitializeComponent();
            _login = string.Empty;
            _password = string.Empty;
        }

        private void Button_Save_OnClick(object sender, RoutedEventArgs e)
        {
            _login = InputLogin.Text;
            _password = InputPassword.Text;
            Label_Output.Content += "Данные сохранены";
        }
        private void Button_Show_Click(object sender, RoutedEventArgs e)
        {
            Label_Output.Content = _login;
            Label_Output2.Content = _password;
        }
        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            _login = null;
            _password = null;
        }
    }
}
