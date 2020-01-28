using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolarisOneWeb.Models
{
    public class Check
    {
        public int CheckId { get; set; }
        public Tactic CheckedTactic { get; set; }
        public string CheckNotes { get; set; }
        public DateTime CheckDate { get; set; }
        public bool IsChecked { get; set; }
    }
}
