using PolarisOneWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolarisOneWeb.Data.DataInterfaces
{
    public interface ICheckInData
    {
        public IEnumerable<Check> GetChecks();
        public Check GetCheckIn(int id);
        public IEnumerable<Check> GetTacticCheckIns(Tactic tactic);
        public IEnumerable<Check> GetStrategyCheckIns(Strategy strategy);

        public IEnumerable<Check> GetCheckInsByDayOfWeek(DayOfWeek dayOfWeek);
    }
}
