using PolarisOneWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolarisOneWeb.Data.DataInterfaces
{
    public interface IStrategyData
    {
        public IEnumerable<Strategy> GetStrategies();
        public Strategy GetStrategy(int strategyId);
        public void UpdateStrategy(Strategy strategy);
    }
}
