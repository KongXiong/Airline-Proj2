using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for GoogleCalViewer.xaml
    /// </summary>
    public partial class GoogleCalViewer : Window
    {
        public ObservableCollection<string> events { get; set; }
        public ObservableCollection<string> dates { get; set; }
        public GoogleCalViewer()
        {
            InitializeComponent();
            Loaded += listBox_Loaded;
        }
        

        private void listBox_Loaded(object sender, RoutedEventArgs e)
        {
            CalendarReader cl = new CalendarReader();
            cl.GoogleMain();
            events = new ObservableCollection<string>(cl.gcevents);
            dates = new ObservableCollection<string>(cl.dates);
            foreach(string f in events)
            {
                foreach(string d in dates)
                {
                    listBox.Items.Add((f.ToString() + "    " + (d) + "\n"));
                }
            }
        }
    }
}
