using System;
using Airline_proj;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace WpfApplication2
{
    internal class passengerViewModel
    {
            public ObservableCollection<Passenger> readJSONFile { get; private set; }
        public passengerViewModel()
        {
            List<Passenger> psngrs = new List<Passenger>();
            FileReader FileRead = new FileReader();

            psngrs = FileRead.LoadJson();
            readJSONFile = new ObservableCollection<Passenger>(psngrs);
        }


    }
}