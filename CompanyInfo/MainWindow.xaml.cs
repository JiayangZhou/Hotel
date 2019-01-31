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

namespace CompanyInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<People> people = new List<People>();
        public MainWindow()
        {
            
            InitializeComponent();
            CreatePeople();
            properties.ItemsSource = people;

        }

        private void CreatePeople()
        {

            people.Add(new People { FirstName = "Tim", LastName = "Smith" });
            people.Add(new People { FirstName = "Tom", LastName = "Johnson" });
            people.Add(new People { FirstName = "David", LastName = "Williams" });

        }

        private void okayButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{propertyName.Text} recieved");
        }

        private void MyCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;
            if (calendar.SelectedDate.HasValue)
            {
                DateTime date = calendar.SelectedDate.Value;
                try
                {
                    tbDataSelected.Text = date.ToShortDateString();

                }
                catch (NullReferenceException)
                {

                }
            }
        }
    }
}
