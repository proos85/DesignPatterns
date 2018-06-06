using Patterns.Testing._1_With_Testing.Factories.PizzaIngredientsFactories;

namespace Patterns.Testing._1_With_Testing.Pizzas
{
    public sealed class NyStyleSalamiPizza : Pizza
    {
        public NyStyleSalamiPizza(IPizzaIngredientFactory ingredientFactory)
        {
            Name = "NY Style Sauce and Salami pizza";
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
            Veggies = ingredientFactory.CreateVeggies();
            Cost = 7.5;
        }
    }
}