using OrderSystem.Dishes;
using OrderSystem.Interfaces;
using OrderSystem.Strategies;

namespace Tests
{
    public class StrategyTests
    {
        [Fact]
        public void OrdinaryStrategy_ShouldCalculateRightCost()
        {
            var strategy = new OrdinaryStrategy();
            var dishes = new List<IDish>
            {
                new Pasta(),  
                new Salad()   
            };
            var finalCost = strategy.DefineFinalCost(dishes);
            
            var expectedCost = (650 + 400) * 1.13m + 300;
            Assert.Equal(expectedCost, finalCost);
        }
    }
}