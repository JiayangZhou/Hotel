using Caliburn.Micro;
using CompanyUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyUI.ViewModels
{
    public class ShellViewModel: Conductor<object>
    {
        private string _firstName ="Jiayang";
        private string _lastName = "Zhou";
        private BindableCollection<Person> _people =new BindableCollection<Person>();
        private Person _selectedPerson;

        public ShellViewModel()
        {
            People.Add(new Person { FirstName = "John", LastName = "Smith" });
            People.Add(new Person { FirstName = "Bob", LastName = "Jones" });
            People.Add(new Person { FirstName = "Tom", LastName = "Storm" });
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public BindableCollection<Person> People
        {
            get { return _people; }
            set { _people = value; }
        }
        

        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

        public bool CanClear(string firstName, string lastName)
        {
            return !String.IsNullOrWhiteSpace(firstName) || !String.IsNullOrWhiteSpace(lastName);
        }

        public void Clear(string firstName, string lastName)
        {
            FirstName = "";
            LastName = "";
        }

        public void LoadPageOne()
        {
            ActivateItem( new FirstChildViewModel());
        }

        public void LoadPageTwo()
        {
            ActivateItem(new SecondChildViewModel());
        }
    }
}
