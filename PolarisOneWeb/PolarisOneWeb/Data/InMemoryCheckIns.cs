using PolarisOneWeb.Data.DataInterfaces;
using PolarisOneWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolarisOneWeb.Data
{
    public class InMemoryCheckIns : ICheckInData
    {
        private readonly List<Check> checks;
        private readonly InMemoryTactics inMemoryTactics = new InMemoryTactics();
        public InMemoryCheckIns()
        {
            this.checks = new List<Check>()
            {
                new Check()
                {
                    CheckId = 1,
                    CheckDate = DateTime.Now,
                    CheckedTactic = inMemoryTactics.GetTactic(1),
                    CheckNotes = "working on making a battle plan app.",
                    IsChecked = true
                },
                new Check()
                {
                    CheckId = 2,
                    CheckDate = DateTime.Parse("2020-01-25"),
                    CheckedTactic = inMemoryTactics.GetTactic(5),
                    CheckNotes = "Been doing the eliptical, since i still have lower levels of energy.",
                    IsChecked = true
                },
                new Check()
                {
                    CheckId = 3,
                    CheckDate = DateTime.Parse("2020-01-20"),
                    CheckedTactic = inMemoryTactics.GetTactic(5),
                    CheckNotes = "Been doing the eliptical, 10 incline, 35 resistance, feeling at 10 mins left",
                    IsChecked = true
                },
                new Check()
                {
                    CheckId = 4,
                    CheckDate = DateTime.Parse("2020-01-21"),
                    CheckedTactic = inMemoryTactics.GetTactic(5),
                    CheckNotes = "Been doing the eliptical, 10 incline, 35 resistance, feeling at 10 mins left",
                    IsChecked = true,
                },
                new Check()
                {
                    CheckId = 5,
                    CheckDate = DateTime.Now,
                    CheckedTactic = inMemoryTactics.GetTactic(4),
                    CheckNotes = "Connecting with wife",
                    IsChecked = true,
                }
            };
        }

        public Check GetCheckIn(int id)
        {
            return checks.FirstOrDefault(c => c.CheckId == id);
        }

        public IEnumerable<Check> GetCheckInsByDayOfWeek(DayOfWeek dayOfWeek)
        {
            return checks.Where(c => c.CheckDate.DayOfWeek == dayOfWeek);
        }

        public IEnumerable<Check> GetChecks()
        {
            return checks;
        }

        public IEnumerable<Check> GetStrategyCheckIns(Strategy strategy)
        {
            return checks.Where(c => c.CheckedTactic.TacticStrategy.StartegyId == strategy.StartegyId);
        }

        public IEnumerable<Check> GetTacticCheckIns(Tactic tactic)
        {
            return checks.Where(c => c.CheckedTactic.TacticId == tactic.TacticId);
        }
    }
}
