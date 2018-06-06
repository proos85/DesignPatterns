using Patterns.Testing._1_With_Testing.Ingredients.Veggies;
using Patterns.Testing._1_With_Testing.Pizzas;

namespace Patterns.Testing._1_With_Testing.PizzaIngredientDecorators
{
    public class ExtraOnion : PizzaIngredientDecorator
    {
        public ExtraOnion(Pizza pizza) : base(pizza)
        {
            AddExtraIngredient(new Onion(), 1);
        }
    }
}