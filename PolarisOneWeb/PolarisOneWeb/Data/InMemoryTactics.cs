using PolarisOneWeb.Data.DataInterfaces;
using PolarisOneWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolarisOneWeb.Data
{
    public class InMemoryTactics : ITacticData
    {
        private List<Tactic> TacticsDb;
        private InMemoryStrategy StrategiesDb;
        public InMemoryTactics()
        {
            this.StrategiesDb = new InMemoryStrategy();
            this.TacticsDb = new List<Tactic>()
            {
                new Tactic
                {
                    TacticId = 1,
                    TacticCommit = "I will build an application in Server Size Blazor.",
                    TacticDescription = "Every Saturday Morning, Sunday Morning I will build an application in Server Size Blazor and publish it online for consumer use",
                    TacticFrequency = 4,
                    TacticStart = DateTime.Parse("2020-01-01"),
                    TacticEnd = DateTime.Parse("2020-04-01"),
                    DoneOnDayOfWeeks = new List<DayOfWeek>(){ DayOfWeek.Saturday, DayOfWeek.Sunday},
                    IsImportant = true,
                    TacticStrategy = StrategiesDb.GetStrategy(1)
                },
                new Tactic
                {
                    TacticId = 2,
                    TacticCommit = "I will create an Android App.",
                    TacticDescription = "Every Monday, Tuesday, Thursday night I will learn to create an application for the Android Platform",
                    TacticFrequency = 4,
                    TacticStart = DateTime.Parse("2020-01-01"),
                    TacticEnd = DateTime.Parse("2020-04-01"),
                    DoneOnDayOfWeeks = new List<DayOfWeek>(){ DayOfWeek.Saturday, DayOfWeek.Sunday},
                    IsImportant = true,
                    TacticStrategy = StrategiesDb.GetStrategy(5)
                },
                new Tactic
                {
                    TacticId = 3,
                    TacticCommit = "I will read for 20 minutes.",
                    TacticDescription = "Every Monday, Tuesday, Thursday night I will read for 20 minutes prior to sleeping",
                    TacticFrequency = 3,
                    TacticStart = DateTime.Parse("2020-01-01"),
                    TacticEnd = DateTime.Parse("2020-04-01"),
                    DoneOnDayOfWeeks = new List<DayOfWeek>(){ DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Thursday},
                    IsImportant = true,
                    TacticStrategy = StrategiesDb.GetStrategy(2)
                },
                new Tactic
                {
                    TacticId = 4,
                    TacticCommit = "I will connect with someone.",
                    TacticDescription = "Every month i will schedule to grab coffee with someone",
                    TacticFrequency = 3,
                    TacticStart = DateTime.Parse("2020-01-01"),
                    TacticEnd = DateTime.Parse("2020-04-01"),
                    DoneOnDayOfWeeks = new List<DayOfWeek>(){DayOfWeek.Monday},
                    IsImportant = true,
                    TacticStrategy = StrategiesDb.GetStrategy(6)
                },
                new Tactic
                {
                    TacticId = 5,
                    TacticCommit = "I will run.",
                    TacticDescription = "Every Monday, Tuesday, Thursday night i will run for one hour",
                    TacticFrequency = 3,
                    TacticStart = DateTime.Parse("2020-01-01"),
                    TacticEnd = DateTime.Parse("2020-04-01"),
                    DoneOnDayOfWeeks = new List<DayOfWeek>(){ DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Thursday},
                    IsImportant = true,
                    TacticStrategy = StrategiesDb.GetStrategy(3)
                },
                new Tactic
                {
                    TacticId = 6,
                    TacticCommit = "I will relax.",
                    TacticDescription = "Every Sunday night spend time to relax",
                    TacticFrequency = 3,
                    TacticStart = DateTime.Parse("2020-01-01"),
                    TacticEnd = DateTime.Parse("2020-04-01"),
                    DoneOnDayOfWeeks = new List<DayOfWeek>(){ DayOfWeek.Sunday},
                    IsImportant = true,
                    TacticStrategy = StrategiesDb.GetStrategy(2)
                }
            };
        }

        public IEnumerable<Tactic> GetStrategyTactics(Strategy strategy)
        {
            throw new NotImplementedException();
        }

        public Tactic GetTactic(int id)
        {
            return TacticsDb.FirstOrDefault(t => t.TacticId == id);
        }

        public IEnumerable<Tactic> GetTactics()
        {
            return TacticsDb;
        }

        public IEnumerable<Tactic> GetTacticsByDay(DayOfWeek dayOfWeek)
        {
            return TacticsDb.Where(t => t.DoneOnDayOfWeeks.Contains(dayOfWeek));
        }

        public bool UpdateTactic(Tactic tactic)
        {
            var oldTactic = GetTactic(tactic.TacticId);
            oldTactic.TacticDescription = tactic.TacticDescription;
            oldTactic.IsImportant = tactic.IsImportant;
            oldTactic.IsUrgent = tactic.IsUrgent;
            oldTactic.TacticStart = tactic.TacticStart;
            oldTactic.TacticEnd = tactic.TacticEnd;
            oldTactic.TacticFrequency = tactic.TacticFrequency;

            return true;
        }
    }
}
