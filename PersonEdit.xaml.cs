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
using System.Collections.ObjectModel;

namespace ListView
{
    /// <summary>
    /// Interaction logic for PersonEdit.xaml
    /// </summary>
    public partial class PersonEdit : Window
    {
        bool IsUpdating { get; set; }
        public PersonEdit()
        {
            InitializeComponent();
            DataContext = new Person();
            IsUpdating = false;
        }
        public PersonEdit(Person p)
        {
            InitializeComponent();
            DataContext = p;
            IsUpdating = true;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if( IsUpdating == false)
            {
                Person.ListOfPeople.Add((Person)DataContext);
            }
            this.Close();
        }
    }
}
