using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ACME.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployedDate { get; set; }
        public DateTime TerminatedDate { get; set; }

        public virtual Person Person { get; set; }
    }
}