using PolarisOneWeb.Data.DataInterfaces;
using PolarisOneWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolarisOneWeb.Data
{
    public class InMemoryStrategy : IStrategyData
    {
        private List<Strategy> StrategiesDb;
        public InMemoryStrategy()
        {
            this.StrategiesDb = new List<Strategy>()
            {
                new Strategy()
                {
                    StartegyId = 1,
                    StrategyTitle = "Creating an Application",
                    StrategyDescription = "Creating an application that people would want to use, strating with a to-do list"
                },
                new Strategy()
                {
                    StartegyId = 2,
                    StrategyTitle = "Doing a better job",
                    StrategyDescription = "Becoming better that your job takes time and intentionality, reading your books will help you in your journey"
                },
                new Strategy()
                {
                    StartegyId = 3,
                    StrategyTitle = "1:35 Half Marathon",
                    StrategyDescription = "Your recent result from last year was 1:37 Half Marathon, with a little intentionality you can surely get to 1:35. Just gotta keep up those miles and stave of injuries."
                },
                new Strategy()
                {
                    StartegyId = 4,
                    StrategyTitle = "Increasing Creativity",
                    StrategyDescription = "Watching those Disney Imagineering shows was inspiring. One area we haven't explored in a while is your creativity. Create time for it and give it a try. No experience required"
                },
                new Strategy()
                {
                    StartegyId = 5,
                    StrategyTitle = "Starting with Android",
                    StrategyDescription = "So you want to create apps, well first you have to learn how to make apps on a platform."
                },
                new Strategy()
                {
                    StartegyId = 6,
                    StrategyTitle = "Staying Connected",
                    StrategyDescription = "Its important that you keep up with your friends and colleages, this is your tribe, you build it and care for it."
                }
            };
        }
        public IEnumerable<Strategy> GetStrategies()
        {
            return StrategiesDb;
        }

        public Strategy GetStrategy(int strategyId)
        {
            return StrategiesDb.FirstOrDefault(s => s.StartegyId == strategyId);
        }

        public void UpdateStrategy(Strategy strategy)
        {
            var oldStrategy = GetStrategy(strategy.StartegyId);
            oldStrategy.StrategyDescription = strategy.StrategyDescription;
            oldStrategy.StrategyTitle = strategy.StrategyTitle;
        }
    }
}
