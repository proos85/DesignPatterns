using Patterns.Testing._1_With_Testing.Ingredients.Veggies;
using Patterns.Testing._1_With_Testing.Pizzas;

namespace Patterns.Testing._1_With_Testing.PizzaIngredientDecorators
{
    public class ExtraMushroom : PizzaIngredientDecorator
    {
        public ExtraMushroom(Pizza pizza) : base(pizza)
        {
            AddExtraIngredient(new Mushroom(), .5);
        }
    }
}