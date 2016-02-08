using System.Collections.ObjectModel;
using System.Collections.Generic;
using System;
using Airline_proj;

namespace WpfApplication2
{
    public class ComboboxViewModel
    {
        public ObservableCollection<Passenger> readJSONFile { get; private set; }
        public ObservableCollection<string> CmbContent { get; private set; }
        public ObservableCollection<string> CmbOrContent { get; private set; }
        public ObservableCollection<string> CmbClassContent { get; private set; }
        public ObservableCollection<string> columCollect { get; private set; }
        public ObservableCollection<string> rowsCollect { get; private set; }
        public List<string> _column = new List<string>();
        public List<string> _rows = new List<string>();
        public ComboboxViewModel()
        {
            Flight_Dictionary FD = new Flight_Dictionary();
            File_Reader psgList = new File_Reader();
            CmbContent = new ObservableCollection<string>(FD.giveList());
            CmbOrContent = new ObservableCollection<string>(FD.originList);
            CmbClassContent = new ObservableCollection<string>(FD.seatClass);
            columCollect = new ObservableCollection<string>(getColumns());
            rowsCollect = new ObservableCollection<string>(getRows());
            var readJSONFile = new ObservableCollection<Passenger>(psgList.readFile());
        }
        public List<string> getColumns()
        {
            foreach (Columns name in Enum.GetValues(typeof(Columns)))
            {
                _column.Add(name.ToString());
            }
                return _column;
        }
        public List<string> getRows()
        {
            foreach (Rows name in Enum.GetValues(typeof(Rows)))
            {
              _rows.Add(name.ToString());
            }
                return _rows;
        }
    }
}
