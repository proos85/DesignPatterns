using System;
using Patterns.Testing._1_With_Testing.Pizzas;
using Patterns.Testing._1_With_Testing.PizzaStorePizzaBuilders.Chicago;

namespace Patterns.Testing._1_With_Testing
{
    public class OrderChicagoStylePizzaExample : IOrderChicagoStylePizzaExample
    {
        private readonly IChicagoPizzaStorePizzaBuilder _pizzaBuilder;

        public OrderChicagoStylePizzaExample(IChicagoPizzaStorePizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void PlayOrderPizzaExample()
        {
            var pizza = _pizzaBuilder
                .CreateBasicPizza(PizzaType.Salami)
                .AddMushrooms()
                .BuildPizza();

            Console.WriteLine(pizza);
        }
    }
}