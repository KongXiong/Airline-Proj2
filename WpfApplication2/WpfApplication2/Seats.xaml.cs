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
using WpfApplication2;
using Airline_proj;
namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Seats.xaml
    /// </summary>
    public partial class Seats : Window
    {
        public Seats()
        {
            InitializeComponent();
            DataContext = new ComboboxViewModel();

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            FileWriter psngrToFile = new FileWriter();
            psngrToFile.Jwriter(nameTextBox.Text, datepicksale.Text,(comboBox.Text + comboBox1.Text), comboBoxdest.Text, comboBox1_Copy.Text);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Passengers passngr = new Passengers();
            passngr.Show();
        }
    }
}
