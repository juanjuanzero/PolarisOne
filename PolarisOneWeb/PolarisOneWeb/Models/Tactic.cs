using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolarisOneWeb.Models
{
    public class Tactic
    {
        public Tactic()
        {

        }
        public Tactic(Strategy strategy)
        {
            this.TacticStrategy = strategy;
        }
        public int TacticId { get; set; }
        public string TacticCommit { get; set; }
        public string TacticDescription { get; set; }
        public DateTime? TacticStart { get; set; }
        public DateTime? TacticEnd { get; set; }
        public int TacticFrequency { get; set; }
        public bool IsImportant { get; set; }
        public bool IsUrgent { get; set; }

        public List<DayOfWeek> DoneOnDayOfWeeks { get; set; }

        public Strategy TacticStrategy { get; set; }
    }
}
