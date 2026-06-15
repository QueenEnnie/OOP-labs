using OrderSystem.Decorators;
using OrderSystem.Dishes;
using OrderSystem.Factories;
using OrderSystem.Interfaces;
using OrderSystem.Strategies;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Bruschettas bread = new Bruschettas();
            Pasta pasta = new Pasta();
            List<IDish> dishes = new List<IDish>();
            dishes.Add(bread);
            dishes.Add(pasta);
            
            Menu menu = new Menu(dishes);
            menu.Display();
            
            IDish spicyPasta = new ExtraSpicy(pasta);
            OrderService system = new OrderService();
            FastOrderFactory factory = new FastOrderFactory();
            
            int orderId = system.CreateOrder(dishes, factory);
            
            system.AddDish(spicyPasta, orderId);
            system.ChangeStatus(orderId);
            
        }
        
    }
}
