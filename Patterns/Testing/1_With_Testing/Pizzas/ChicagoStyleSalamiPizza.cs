using System;
using Patterns.Testing._1_With_Testing.Factories.PizzaIngredientsFactories;

namespace Patterns.Testing._1_With_Testing.Pizzas
{
    public sealed class ChicagoStyleSalamiPizza : Pizza
    {
        public ChicagoStyleSalamiPizza(IPizzaIngredientFactory ingredientFactory)
        {
            Name = "Chicago Style Deep Dish Salami pizza";
            Dough = ingredientFactory.CreateDough();
            Cheese = ingredientFactory.CreateCheese();
            Veggies = ingredientFactory.CreateVeggies();
            Clams = ingredientFactory.CreateClams();
            Cost = 12;
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}