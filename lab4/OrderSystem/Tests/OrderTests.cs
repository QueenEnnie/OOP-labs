using OrderSystem;
using OrderSystem.Dishes;
using OrderSystem.Interfaces;
using OrderSystem.Strategies;

namespace Tests
{
    public class OrderTests
    {
        [Fact]
        public void Order_ShouldCreateOrder()
        {
            var dishes = new List<IDish> { new Pasta(), new Salad() };
            var order = new Order(dishes, 42);
            
            Assert.Equal(2, order.Dishes.Count);
            Assert.Equal(42, order.OrderNumber);
            Assert.False(order.IsFinished);
        }
        
        [Fact]
        public void Order_ShouldAddDish()
        {
            var dishes = new List<IDish> { new Pasta() };
            var order = new Order(dishes, 1);
            order.SetCostStrategy(new OrdinaryStrategy());
            var initialCost = order.GetCost();
            var salad = new Salad();
            order.AddDish(salad);
            
            Assert.Contains(salad, order.Dishes);
            Assert.Equal(2, order.Dishes.Count);
        }
    }
}

