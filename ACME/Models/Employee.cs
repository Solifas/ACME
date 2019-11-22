using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACME.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployedDate { get; set; }
        public DateTime TerminatedDate { get; set; }

        public virtual Person Person { get; set; }
    }
}