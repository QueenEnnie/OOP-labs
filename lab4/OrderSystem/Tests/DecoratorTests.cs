using OrderSystem.Decorators;
using OrderSystem.Dishes;
using OrderSystem.Interfaces;

namespace Tests
{
    public class DecoratorTests
    {
        [Fact]
        public void ExtraSpicy_ShouldCreateNewName()
        {
            IDish pasta = new Pasta();
            IDish spicyPasta = new ExtraSpicy(pasta);
            var name = spicyPasta.GetName();
            
            Assert.Equal("Pasta spicy", name);
        }
        
        [Fact]
        public void ExtraSpicy_ShouldReturnPrice()
        {
            IDish pasta = new Pasta();
            IDish spicyPasta = new ExtraSpicy(pasta);
            var price = spicyPasta.GetPrice();
            
            Assert.Equal(pasta.GetPrice(), price);
        }
    }
}