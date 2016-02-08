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
using GoogleCalendarReaderLogic;


namespace Googletrywpf
{
    
    public partial class AddEventGCalendar : Window
    {
        public AddEventGCalendar()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            string airplaneid = AirplaneIdBox.Text;
            string destination = DestinationBox.Text;
            DateTime result = datepicker1.SelectedDate.Value.Date;
            GoogleCWriter pl = new GoogleCWriter();
            pl.GoogleMainWriter(airplaneid, airplaneid, destination, result, result);
            MessageBox.Show("Event Added");
            
            

            
        }

        private void AirplaneIdBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
