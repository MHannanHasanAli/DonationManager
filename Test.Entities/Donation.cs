using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entities
{
    public class Donation
    {
        [Key]
        public int _id { get; set; }
        public decimal _Amount{ get; set; }
        public decimal _Fees { get; set; }
        public string _Intention { get; set; }
        public string _Type { get; set; }
        public DateTime _ExportDate { get; set; } = DateTime.Now;
    }
}
