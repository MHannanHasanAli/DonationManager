using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entities
{
    public class Project
    {
        [Key] public int _id { get; set; }
        public string _Name { get; set; }
        public List<string> _Countries { get; set; }
        public decimal _EstimatedTarget { get; set; }
        public string _ManagedBy { get; set; }
        public int _TeamsOnTheGround { get; set; }
        public DateTime _ProjectInitiated { get; set; }
        public DateTime? _ProjectCompleted { get; set; }
        public string? _Notes { get; set; }
    }
}
