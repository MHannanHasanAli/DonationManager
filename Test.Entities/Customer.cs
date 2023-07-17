using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entities
{
    public class Customer
    {
        [Key]
        public int _id { get; set; }
        public string _Name { get; set; }
        public string _Address { get; set; }
        public string _PhoneNumber { get; set; }
        public string _Email { get; set; }
        public DateTime _ExportDate { get; set; } = DateTime.Now;
    }
}
