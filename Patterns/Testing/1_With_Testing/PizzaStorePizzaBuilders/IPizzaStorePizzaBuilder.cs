using Patterns.Testing._1_With_Testing.Pizzas;

namespace Patterns.Testing._1_With_Testing.PizzaStorePizzaBuilders
{
    public interface IPizzaStorePizzaBuilder
    {
        IPizzaStorePizzaBuilder CreateBasicPizza(PizzaType type);

        IPizzaStorePizzaBuilder AddMushrooms();

        IPizzaStorePizzaBuilder AddOnions();

        Pizza BuildPizza();
    }
}