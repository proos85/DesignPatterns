using System.Collections.Generic;
using Patterns.Testing._1_With_Testing.Ingredients.Cheeses;
using Patterns.Testing._1_With_Testing.Ingredients.Clams;
using Patterns.Testing._1_With_Testing.Ingredients.Doughes;
using Patterns.Testing._1_With_Testing.Ingredients.Sauces;
using Patterns.Testing._1_With_Testing.Ingredients.Veggies;

namespace Patterns.Testing._1_With_Testing.Factories.PizzaIngredientsFactories.Ny
{
    public class NyPizzaIngredientFactory : INyPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }

        public IList<IVeggies> CreateVeggies()
        {
            return new List<IVeggies>
            {
                new Garlic(),
                new Onion(),
                new Mushroom()
            };
        }
    }
}