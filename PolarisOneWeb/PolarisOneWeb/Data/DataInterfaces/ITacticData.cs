using PolarisOneWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolarisOneWeb.Data.DataInterfaces
{
    public interface ITacticData
    {
        public IEnumerable<Tactic> GetTactics();
        public Tactic GetTactic(int id);
        public bool UpdateTactic(Tactic tactic);
        public IEnumerable<Tactic> GetStrategyTactics(Strategy strategy);
    }
}
