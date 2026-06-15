using OrderSystem;
using OrderSystem.Dishes;
using OrderSystem.Interfaces;
using OrderSystem.States;
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

        [Fact]
        public void Order_ChangeStatus_ShouldMoveThroughStatesAndFinish()
        {
            var order = new Order([new Pasta()], 1);

            order.ChangeStatus();
            Assert.IsType<DeliveryState>(order.OrderState);

            order.ChangeStatus();
            Assert.IsType<ReadyState>(order.OrderState);

            order.ChangeStatus();
            Assert.True(order.IsFinished);
        }

        [Fact]
        public void Order_GetCost_ShouldUseOrdinaryStrategyByDefault()
        {
            var order = new Order([new Pasta()], 1);

            Assert.Equal(650 * 1.13m + 300, order.GetCost());
        }

        [Fact]
        public void System_GetCost_WithMissingOrder_ShouldThrowClearError()
        {
            var system = new OrderService();

            var exception = Assert.Throws<KeyNotFoundException>(() => system.GetCost(999));
            Assert.Contains("999", exception.Message);
        }
    }
}

