using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyUI.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }

        public bool IsAlive { get; set; }

        public decimal AccountBalance { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();

        public Address PrimaryAddress { get; set; }

      public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }

        }


    }
}
