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
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using test;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            string loginWPF = textBox1.Text;
            string passWPF = textBox2.Password;
            login_pass userLogin = new login_pass();
            bool access = userLogin.readFile(loginWPF, passWPF);
            if (access == true)
            {
            }
            else
            {
                MessageBox.Show("Please Check Username and Password");
                
            }
            this.Hide();
            Seats seats = new Seats();

            seats.Show();  
        }
    }
}
