using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Patterns.Testing._1_With_Testing.Ingredients.Cheeses;
using Patterns.Testing._1_With_Testing.Ingredients.Clams;
using Patterns.Testing._1_With_Testing.Ingredients.Sauces;
using Patterns.Testing._1_With_Testing.Ingredients.Veggies;
using Patterns.Testing._1_With_Testing.Ingredients.Doughes;

namespace Patterns.Testing._1_With_Testing.Pizzas
{
    public abstract class Pizza
    {
        public virtual string Name { get; set; }
        public virtual IDough Dough { get; set; }
        public virtual ISauce Sauce { get; set; }
        public virtual ICheese Cheese { get; set; }
        public virtual IClams Clams { get; set; }
        public virtual IList<IVeggies> Veggies { get; set; } = new List<IVeggies>();
        public virtual double Cost { get; set; }

        public void Prepare()
        {
            Console.WriteLine($"Prepare the pizza ({GetType().Name})");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding topping...");
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Placing the pizza in official PizzaStore box");
        }

        public override string ToString()
        {
            return $"{Environment.NewLine}\tPizza: '{Name}'{Environment.NewLine}" +
                   $"\tDough: {(Dough != null ? Dough.GetType().Name : "-")}{Environment.NewLine}" +
                   $"\tSauce: {(Sauce != null ? Sauce.GetType().Name : "-")}{Environment.NewLine}" +
                   $"\tCheese: {(Cheese != null ? Cheese.GetType().Name : "-")}{Environment.NewLine}" +
                   $"\tClams: {(Clams != null ? Clams.GetType().Name : "-")}{Environment.NewLine}" +
                   $"\tVeggies: {(Veggies.Any() ? string.Join(",", Veggies.Select(x => x.GetType().Name)) : "-")}{Environment.NewLine}" +
                   $"\tCost: {Cost.ToString("C2", new CultureInfo("nl-NL"))}";
        }
    }
}