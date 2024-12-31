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
    /// Interaction logic for ForgotPwd.xaml
    /// </summary>
    public partial class ForgotPwd : Window
    {
        public ForgotPwd()
        {
            InitializeComponent();
        }

        private void btnchange_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrWhiteSpace(txtnewpwd.Password) || (String.IsNullOrWhiteSpace(txtnewpwdreenter.Password))))
            {
                MessageBox.Show("The password cannot be empty");
            }
            else
            {
                if (txtnewpwd.Password == txtnewpwdreenter.Password)
                {
                    MessageBox.Show("The password is changed successfully");
                }
                else
                {
                    MessageBox.Show("Renter the same password");
                }
             
            }


        }
    }
}
