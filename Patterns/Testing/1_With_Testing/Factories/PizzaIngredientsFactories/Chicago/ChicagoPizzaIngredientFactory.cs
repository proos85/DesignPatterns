using System.Collections.Generic;
using Patterns.Testing._1_With_Testing.Ingredients.Cheeses;
using Patterns.Testing._1_With_Testing.Ingredients.Clams;
using Patterns.Testing._1_With_Testing.Ingredients.Doughes;
using Patterns.Testing._1_With_Testing.Ingredients.Sauces;
using Patterns.Testing._1_With_Testing.Ingredients.Veggies;

namespace Patterns.Testing._1_With_Testing.Factories.PizzaIngredientsFactories.Chicago
{
    public class ChicagoPizzaIngredientFactory : IChicagoPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new MozarellaCheese();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }

        public IList<IVeggies> CreateVeggies()
        {
            return new List<IVeggies>
            {
                new Garlic(),
                new Onion()
            };
        }
    }
}