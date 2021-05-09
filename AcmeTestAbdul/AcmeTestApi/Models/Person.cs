using System;
using System.Collections.Generic;

#nullable disable

namespace AcmeTestApi.Models
{
    public partial class Person
    {
        public Person()
        {
            Employees = new HashSet<Employee>();
        }

        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
