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
using System.Windows.Navigation;
using System.Windows.Shapes;
using GoogleCalendarReaderLogic;

namespace Googletrywpf
{
 
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> events { get; private set; }
        public ObservableCollection<string> dates { get; private set; }
            

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
   
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            CalendarReader cl = new CalendarReader();
            cl.GoogleMain();
            events = new ObservableCollection<string>(cl.gcevents);

            dates = new ObservableCollection<string>(cl.dates);
           
            
            foreach (string f in events)
            {
                foreach(string d in dates)
                {
                    EventListRealG.Items.Add((f.ToString()+ "      " + (d)+"\n"));
                }

            }


        }



        private void EventListRealG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AddEventGCalendar df = new AddEventGCalendar();
            df.Owner = this.Owner;
            df.Show();
            this.Close();
        }
    }
}
