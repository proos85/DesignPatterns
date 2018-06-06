using System;
using Patterns.Testing._1_With_Testing.Pizzas;

namespace Patterns.Testing._1_With_Testing.PizzaStores.Ny
{
    public class NyPizzaStore : PizzaStoreBase, INyPizzaStore
    {
        protected override Pizza CreatePizza<TPizzaIngredientFactory>(PizzaType type, TPizzaIngredientFactory ingredientFactory)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new NyStyleCheesePizza(ingredientFactory);
                case PizzaType.Salami:
                    return new NyStyleSalamiPizza(ingredientFactory);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}