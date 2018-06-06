using System.Collections.Generic;
using Patterns.Testing._1_With_Testing.Ingredients.Cheeses;
using Patterns.Testing._1_With_Testing.Ingredients.Clams;
using Patterns.Testing._1_With_Testing.Ingredients.Doughes;
using Patterns.Testing._1_With_Testing.Ingredients.Sauces;
using Patterns.Testing._1_With_Testing.Ingredients.Veggies;

namespace Patterns.Testing._1_With_Testing.Factories.PizzaIngredientsFactories
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IClams CreateClams();
        IList<IVeggies> CreateVeggies();
    }
}