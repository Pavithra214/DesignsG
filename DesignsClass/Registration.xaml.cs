using System.Windows;

using System.IO;

namespace DesignsClass
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        string name;
        
        public Registration(string username="")
        {
            InitializeComponent();
            name = username;
            if(name=="")
            {
txtname.IsEnabled = true;
                btnregister.Content = "Register";

            }
            else
            {
                txtname.IsEnabled = false;
                btnregister.Content = "Update";
            }

            string userpath = Properties.Settings.Default.Rootpath + "//" + name;
            if (Directory.Exists(userpath))
            {
                string filepath = Path.Join(userpath, name + ".txt");
                if (File.Exists(filepath))
                {
                    string values=File.ReadAllText(filepath);
                    string[] listvalues=values.Split('|');
         
                    txtname.Text= listvalues[0];
                    pbpwd.Password= listvalues[1];
                    txtphone.Text= listvalues[2];
                    txtemail.Text= listvalues[3];

                }

            }



        }

        private void btnregister_Click(object sender, RoutedEventArgs e)
        {
            string userpath = Properties.Settings.Default.Rootpath + "//" + txtname.Text;
            if (!Directory.Exists(userpath))
            {
             Directory.CreateDirectory(userpath);
                string filename=Path.Join(userpath,txtname.Text+".txt");
                string content=$"{txtname.Text}|{pbpwd.Password}|{txtphone.Text}|{txtemail.Text}";
                File.WriteAllText(filename,content);
                MessageBox.Show("Congratulations! The registration is successful");
            }
            else
            {
                MessageBox.Show("The user name already exists. Please choose a different user name");
            }
        }
    }
}
