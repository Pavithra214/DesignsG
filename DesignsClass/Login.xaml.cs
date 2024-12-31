using System.Windows;
using System.IO;
namespace DesignsClass
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        string Rootpath;
      
        
       
        public Login()
        {
            InitializeComponent();
           
          
            Rootpath = System.Environment.SpecialFolder.CommonApplicationData.ToString();
            Rootpath = Rootpath + "//DesignsClass";
            if(!Directory.Exists(Rootpath))
            {
                Directory.CreateDirectory(Rootpath);
            }
            DesignsClass.Properties.Settings.Default.Rootpath = Rootpath;
            DesignsClass.Properties.Settings.Default.Save();
        }

        private void Registerbtn_Click(object sender, RoutedEventArgs e)
        {
Registration reg= new Registration();
            reg.Show();
            this.Close();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
string userpath=Properties.Settings.Default.Rootpath+"//"+txtname.Text;
            if (Directory.Exists(userpath))
            {
                string filepath=Path.Join(userpath,txtname.Text+".txt");
                if (File.Exists(filepath))
                {
                    string values=File.ReadAllText(filepath);
                    string[] valuelist=values.Split('|');
                    if(txtname.Text==valuelist[0] && pbpwd.Password == valuelist[1])
                    {
                      Home home=new Home(txtname.Text);
                        home.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid user name and password");
                }
            }
            else
            {
                MessageBox.Show("Invalid user name and password");
            }

        }
    }
}
