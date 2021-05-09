using System;
using System.Collections.Generic;

#nullable disable

namespace AcmeTestApi.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public string EmployeeNum { get; set; }
        public DateTime EmployedDate { get; set; }
        public DateTime? TerminatedDate { get; set; }

        public virtual Person Person { get; set; }
    }
}
