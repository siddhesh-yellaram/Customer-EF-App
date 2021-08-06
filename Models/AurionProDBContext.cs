using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomerEFApp.Models
{
    public class AurionProDBContext:DbContext
    {
        public AurionProDBContext() : base("AurionProDB") { }
        public DbSet<Customer> Customers { get; set; }
    }
}