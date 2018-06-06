using Patterns.Testing._1_With_Testing.Factories.PizzaIngredientsFactories;
using Patterns.Testing._1_With_Testing.Pizzas;

namespace Patterns.Testing._1_With_Testing.PizzaStores
{
    public interface IPizzaStore
    {
        Pizza OrderPizza<TPizzaIngredientFactory>(
            PizzaType type,
            TPizzaIngredientFactory ingredientFactory) where TPizzaIngredientFactory : IPizzaIngredientFactory;
    }
}