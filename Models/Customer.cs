using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CustomerEFApp.Models
{
    [Table("Customers")]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int? Balance { get; set; }
        public string Type { get; set; }
    }
}