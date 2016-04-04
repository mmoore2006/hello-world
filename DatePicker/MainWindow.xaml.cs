using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace DatePicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private DateTime _afterDate;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            AfterDate = new DateTime(2015, 6,7);
        }

        private string _afterText;
        private string _currentDateString;

        public string AfterText
        {
            get { return _afterText; }
            set
            {
                _afterText = value;
                CurrentDateString = value;
                OnPropertyChanged();
            }
        }

        public DateTime AfterDate
        {
            get { return _afterDate; }
            set 
            { 
                _afterDate = value;
                CurrentDateString = value.ToLongDateString();
                OnPropertyChanged();  
            }
        }

        //public string CurrentDateString
        //{
        //    get { return _currentDateString; }
        //    set
        //    {
        //        DateTime dateTime;
        //        if (DateTime.TryParse(value, out dateTime))
        //        {
        //            _currentDateString = dateTime.ToLongDateString();
        //        }
        //        else
        //            _currentDateString = ""; 
        //        OnPropertyChanged(); 
        //    }
        //}

        public string CurrentDateString
        {
            get { return _currentDateString; }
            set
            {
                _currentDateString = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
