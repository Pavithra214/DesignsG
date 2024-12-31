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

namespace DesignsClass
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home(string username)
        {
            InitializeComponent();
            lbluser.Content = username;
            Stackuser.Visibility = Visibility.Hidden;
            StackLocation.Visibility = Visibility.Hidden;
            StackSettings.Visibility = Visibility.Hidden;
           
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLocation_Click(object sender, RoutedEventArgs e)
        {
StackLocation.Visibility = Visibility.Visible;
            Stackuser.Visibility = Visibility.Hidden;
            StackSettings.Visibility = Visibility.Hidden;
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            StackSettings.Visibility = Visibility.Visible;
            StackLocation.Visibility = Visibility.Hidden;
            Stackuser.Visibility = Visibility.Hidden;
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
     Registration reg=new Registration(lbluser.Content.ToString());
            //reg.btnregister.Content = "update";
            reg.Show();

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
           
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnforgotpwd_Click(object sender, RoutedEventArgs e)
        {
            ForgotPwd forgotPwd = new ForgotPwd();
            forgotPwd.Show();
        }
    }
}
