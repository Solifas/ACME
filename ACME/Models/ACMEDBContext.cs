using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ACME.Models
{
    public class ACMEDBContext: DbContext
    {
        public ACMEDBContext(): base("ACME_Database")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> People { get; set; }
        
    }
}