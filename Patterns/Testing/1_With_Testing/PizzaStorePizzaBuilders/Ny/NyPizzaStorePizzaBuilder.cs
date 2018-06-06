using Patterns.Testing._1_With_Testing.Factories.PizzaIngredientsFactories.Ny;
using Patterns.Testing._1_With_Testing.PizzaStores.Ny;

namespace Patterns.Testing._1_With_Testing.PizzaStorePizzaBuilders.Ny
{
    public class NyPizzaStorePizzaBuilder : PizzaStorePizzaBuilderBase, INyPizzaStorePizzaBuilder
    {
        public NyPizzaStorePizzaBuilder(
            INyPizzaStore pizzaStore,
            INyPizzaIngredientFactory ingredientFactory) : base(pizzaStore, ingredientFactory)
        {
        }
    }
}