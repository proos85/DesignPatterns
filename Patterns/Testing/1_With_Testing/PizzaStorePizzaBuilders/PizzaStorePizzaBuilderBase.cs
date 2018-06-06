using Patterns.Testing._1_With_Testing.Factories.PizzaIngredientsFactories;
using Patterns.Testing._1_With_Testing.PizzaIngredientDecorators;
using Patterns.Testing._1_With_Testing.Pizzas;
using Patterns.Testing._1_With_Testing.PizzaStores;

namespace Patterns.Testing._1_With_Testing.PizzaStorePizzaBuilders
{
    public abstract class PizzaStorePizzaBuilderBase : IPizzaStorePizzaBuilder
    {
        private readonly IPizzaStore _pizzaStore;
        private readonly IPizzaIngredientFactory _ingredientFactory;

        private Pizza _thePizza;

        protected PizzaStorePizzaBuilderBase(
            IPizzaStore pizzaStore,
            IPizzaIngredientFactory ingredientFactory)
        {
            _pizzaStore = pizzaStore;
            _ingredientFactory = ingredientFactory;
        }

        public IPizzaStorePizzaBuilder CreateBasicPizza(PizzaType type)
        {
            _thePizza = _pizzaStore.OrderPizza(type, _ingredientFactory);
            return this;
        }

        public IPizzaStorePizzaBuilder AddMushrooms()
        {
            _thePizza = new ExtraMushroom(_thePizza);
            return this;
        }

        public IPizzaStorePizzaBuilder AddOnions()
        {
            _thePizza = new ExtraOnion(_thePizza);
            return this;
        }

        public Pizza BuildPizza()
        {
            return _thePizza;
        }
    }
}