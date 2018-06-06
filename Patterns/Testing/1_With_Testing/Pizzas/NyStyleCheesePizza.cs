using Patterns.Testing._1_With_Testing.Factories.PizzaIngredientsFactories;

namespace Patterns.Testing._1_With_Testing.Pizzas
{
    public sealed class NyStyleCheesePizza : Pizza
    {
        public NyStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            Name = "NY Style Sauce and Cheese pizza";
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
            Cost = 5.5;
        }
    }
}