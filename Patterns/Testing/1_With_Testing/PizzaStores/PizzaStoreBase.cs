using Patterns.Testing._1_With_Testing.Factories.PizzaIngredientsFactories;
using Patterns.Testing._1_With_Testing.Pizzas;

namespace Patterns.Testing._1_With_Testing.PizzaStores
{
    public abstract class PizzaStoreBase : IPizzaStore
    {
        public Pizza OrderPizza<TPizzaIngredientFactory>(
            PizzaType type, 
            TPizzaIngredientFactory ingredientFactory) where TPizzaIngredientFactory : IPizzaIngredientFactory
        {
            var pizza = CreatePizza(type, ingredientFactory);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        /// <summary>
        /// This is the Factory method
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ingredientFactory"></param>
        /// <returns></returns>
        protected abstract Pizza CreatePizza<TPizzaIngredientFactory>(
            PizzaType type,
            TPizzaIngredientFactory ingredientFactory) where TPizzaIngredientFactory: IPizzaIngredientFactory;
    }
}