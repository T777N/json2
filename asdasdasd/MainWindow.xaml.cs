using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml;

namespace asdasdasd
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



           

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Command.Process process = new Command.Process();
            Models.Properties properties = new Models.Properties();
            properties.Name = nameTb.Text;
            properties.Surname = surnameTb.Text;
            properties.Email = emailTb.Text;
            if (JsonRb.IsChecked.Value)
            {

            process.Start(2,properties);
            }
            else if (XmlRb.IsChecked.Value)
            {
               
                process.Start(1,properties);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            nameTb.Text = "";
            surnameTb.Text = "";
            emailTb.Text = "";

        }
    }
}
