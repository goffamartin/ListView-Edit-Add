using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel; 

namespace ListView
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _Surname;
        public string Surname
        {
            get => _Surname;
            set { _Surname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Surname")); }
        }

        private string _Forname;
        public string Forname
        {
            get => _Forname;
            set { _Forname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Forname")); }
        }

        private DateTime _Birthdate;
        public DateTime Birthdate
        {
            get => _Birthdate;
            set { _Birthdate = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Birthdate")); }
        }

        private string _PersonalID;
        public string PersonalID
        {
            get => _PersonalID;
            set { _PersonalID = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PersonalID")); }
        }
        public static ObservableCollection<Person> ListOfPeople { get; set; } = new ObservableCollection<Person>();
    }
}
