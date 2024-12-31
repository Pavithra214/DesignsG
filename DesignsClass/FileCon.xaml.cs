using System.Windows;
using System.IO;
using Microsoft.Win32;

namespace DesignsClass
{
    /// <summary>
    /// Interaction logic for FileCon.xaml
    /// </summary>
    public partial class FileCon : Window
    {
        public FileCon()
        {
            InitializeComponent();
        }

        

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
   SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Title = "Save your file";
            saveFile.DefaultExt = ".txt";
            saveFile.Filter = "Text File (.txt)|.txt|All files(.)|.";

            //show savefiledialog
            if(saveFile.ShowDialog()==true)
            {
                string filepath=saveFile.FileName;
                txtfilename.Text= filepath;
                File.WriteAllText(filepath,txtcontent.Text);
                MessageBox.Show("File saved");
            }
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open File";
            openFile.DefaultExt = ".txt";
            openFile.Filter = "Textfile(.txt)|.txt|All file(.)|.";
            if (openFile.ShowDialog() == true)
            {
                string filepath=openFile.FileName;
                txtfilename.Text= filepath;
                txtcontent.Text= File.ReadAllText(filepath);
            }
        }

        private void btnReverse_Click(object sender, RoutedEventArgs e)
        {
            string value = "Welcome Pavithra";
            char[] chars=value.ToCharArray();
            Array.Reverse(chars);
            string reversedString=new string(chars);
            MessageBox.Show(reversedString);
        }
    }
}
