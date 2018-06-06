using System;
using Patterns.Testing._1_With_Testing.Pizzas;

namespace Patterns.Testing._1_With_Testing.PizzaStores.Chicago
{
    public class ChicagoPizzaStore : PizzaStoreBase, IChicagoPizzaStore
    {
        protected override Pizza CreatePizza<TPizzaIngredientFactory>(
            PizzaType type, 
            TPizzaIngredientFactory ingredientFactory)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new ChicagoStyleCheesePizza(ingredientFactory);
                case PizzaType.Salami:
                    return new ChicagoStyleSalamiPizza(ingredientFactory);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}