using System.Collections.Generic;
using Patterns.Testing._1_With_Testing.Ingredients.Cheeses;
using Patterns.Testing._1_With_Testing.Ingredients.Clams;
using Patterns.Testing._1_With_Testing.Ingredients.Sauces;
using Patterns.Testing._1_With_Testing.Ingredients.Veggies;
using Patterns.Testing._1_With_Testing.Ingredients.Doughes;
using Patterns.Testing._1_With_Testing.Pizzas;

namespace Patterns.Testing._1_With_Testing.PizzaIngredientDecorators
{
    public class PizzaIngredientDecorator : Pizza
    {
        private Pizza _pizza;

        public override string Name
        {
            get => _pizza.Name;
            set => _pizza.Name = value;
        }
        public override IDough Dough
        {
            get => _pizza.Dough;
            set => _pizza.Dough = value;
        }
        public override ISauce Sauce
        {
            get => _pizza.Sauce;
            set => _pizza.Sauce = value;
        }
        public override ICheese Cheese
        {
            get => _pizza.Cheese;
            set => _pizza.Cheese = value;
        }
        public override IClams Clams
        {
            get => _pizza.Clams;
            set => _pizza.Clams = value;
        }
        public override IList<IVeggies> Veggies
        {
            get => _pizza.Veggies;
            set => _pizza.Veggies = value;
        }
        public override double Cost
        {
            get => _pizza.Cost;
            set => _pizza.Cost = value;
        }

        protected PizzaIngredientDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public Pizza SetDecoratedPizza(Pizza pizza)
        {
            _pizza = pizza;
            return this;
        }

        protected void AddExtraIngredient(
            IVeggies ingredient,
            double increasedCost)
        {
            _pizza?.Veggies.Add(ingredient);
            IncreateCost(increasedCost);
        }

        public override string ToString()
        {
            return _pizza.ToString();
        }

        private void IncreateCost(double value)
        {
            if (_pizza != null)
            {
                var currentCost = _pizza.Cost;
                var increasedCost = currentCost + value;
                _pizza.Cost = increasedCost;
            }
        }
    }
}