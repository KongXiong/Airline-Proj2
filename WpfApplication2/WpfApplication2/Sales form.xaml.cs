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
using JsonFileWriter;


namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Sales_form.xaml
    /// </summary>
    public partial class Sales_form : Window
    {
        public Sales_form()
        {
            InitializeComponent();
            DataContext = new Salesviewmodel();


        }

        

            //populate manifest
            //calculate price

            //this.Hide();
            //Seats seats = new Seats();
            //seats.Show();
        }
    }
}
