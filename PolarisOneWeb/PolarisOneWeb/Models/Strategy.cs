using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolarisOneWeb.Models
{
    public class Strategy
    {
        public int StartegyId { get; set; }
        public string StrategyDescription { get; set; }
        public string StrategyTitle { get; set; }
        public IEnumerable<Tactic> Actions { get; set; }
    }
}
