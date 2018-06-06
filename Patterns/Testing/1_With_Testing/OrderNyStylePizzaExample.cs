using System;
using Patterns.Testing._1_With_Testing.Pizzas;
using Patterns.Testing._1_With_Testing.PizzaStorePizzaBuilders.Ny;

namespace Patterns.Testing._1_With_Testing
{
    public class OrderNyStylePizzaExample : IOrderNyStylePizzaExample
    {
        private readonly INyPizzaStorePizzaBuilder _pizzaBuilder;

        public OrderNyStylePizzaExample(INyPizzaStorePizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }
        
        public void PlayOrderPizzaExample()
        {
            var pizza = _pizzaBuilder
                .CreateBasicPizza(PizzaType.Cheese)
                .AddMushrooms()
                .BuildPizza();

            Console.WriteLine(pizza);
        }
    }
}