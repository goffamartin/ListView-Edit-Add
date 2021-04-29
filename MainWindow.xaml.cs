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

namespace ListView
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Examples
            Person.ListOfPeople.Add(new Person { Forname = "Martin", Surname = "Goffa", Birthdate = new DateTime(2002, 12, 23), PersonalID = "021223/666" });
            Person.ListOfPeople.Add(new Person { Forname = "Pavel", Surname = "Novák", Birthdate = new DateTime(2003, 6, 12), PersonalID = "030612/123" });
            Person.ListOfPeople.Add(new Person { Forname = "Tomáš", Surname = "Adámek", Birthdate = new DateTime(2003, 5, 4), PersonalID = "030504/854" });
            Person.ListOfPeople.Add(new Person { Forname = "David", Surname = "Koritar", Birthdate = new DateTime(2002, 2, 8), PersonalID = "020208/215" });
            Person.ListOfPeople.Add(new Person { Forname = "Roman", Surname = "Krof", Birthdate = new DateTime(2002, 12, 17), PersonalID = "021217/315" });
            Person.ListOfPeople.Add(new Person { Forname = "Jan", Surname = "Procházka", Birthdate = new DateTime(2002, 10, 20), PersonalID = "021020/952" });
            Person.ListOfPeople.Add(new Person { Forname = "Karel", Surname = "Hnilica", Birthdate = new DateTime(2002, 8, 16), PersonalID = "020816/512" });
            Person.ListOfPeople.Add(new Person { Forname = "Alex", Surname = "Motyčka", Birthdate = new DateTime(2002, 3, 21), PersonalID = "020321/482" });
            Person.ListOfPeople.Add(new Person { Forname = "Adam", Surname = "Hofman", Birthdate = new DateTime(2002, 6, 19), PersonalID = "020619/358" });
            Person p = new Person();
            People.DataContext = p;

        }

        private void People_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person p = (Person)((ListBox)sender).SelectedItem;
            DataContext = p;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            People.SelectedIndex = 0;
        }

        private void People_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Person p = (Person)((ListBox)sender).SelectedItem;
            PersonEdit pe = new PersonEdit(p);
            pe.ShowDialog();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            PersonEdit pe = new PersonEdit();
            pe.ShowDialog();
        }
    }
}
