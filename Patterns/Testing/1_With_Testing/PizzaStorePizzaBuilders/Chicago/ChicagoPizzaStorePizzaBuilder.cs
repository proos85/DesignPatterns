using Patterns.Testing._1_With_Testing.Factories.PizzaIngredientsFactories.Chicago;
using Patterns.Testing._1_With_Testing.PizzaStores.Chicago;

namespace Patterns.Testing._1_With_Testing.PizzaStorePizzaBuilders.Chicago
{
    public class ChicagoPizzaStorePizzaBuilder : PizzaStorePizzaBuilderBase, IChicagoPizzaStorePizzaBuilder
    {
        public ChicagoPizzaStorePizzaBuilder(
            IChicagoPizzaStore pizzaStore,
            IChicagoPizzaIngredientFactory ingredientFactory) : base(pizzaStore, ingredientFactory)
        {
        }
    }
}