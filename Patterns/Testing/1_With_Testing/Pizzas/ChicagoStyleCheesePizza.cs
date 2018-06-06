using System;
using Patterns.Testing._1_With_Testing.Factories.PizzaIngredientsFactories;

namespace Patterns.Testing._1_With_Testing.Pizzas
{
    public sealed class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            Name = "Chicago Style Deep Dish Cheese pizza";
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
            Clams = ingredientFactory.CreateClams();
            Cost = 10;
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}