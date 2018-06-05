using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Decorator._4_Abstract_Factory
{
    public static class Example
    {
        public static void Run()
        {
            // Let's order a NY style pizza
            OrderNyStylePizza();

            Console.WriteLine();

            // And order another chicago style pizza
            OrderChicagoStylePizza();

            Console.ReadKey();
        }

        private static void OrderNyStylePizza()
        {
            var nyPizzaStore = new NyPizzaStore();
            var pizza = nyPizzaStore.OrderPizza(PizzaType.Cheese);

            Console.WriteLine(pizza);
        }

        private static void OrderChicagoStylePizza()
        {
            var chicagoPizzaStore = new ChicagoPizzaStore();
            var pizza = chicagoPizzaStore.OrderPizza(PizzaType.Salami);

            Console.WriteLine(pizza);
        }

        #region PizzaType

        private enum PizzaType
        {
            Cheese,
            Salami,
        }

        #endregion

        #region PizzaStore

        private abstract class PizzaStore
        {
            public Pizza OrderPizza(PizzaType type)
            {
                var pizza = CreatePizza(type);

                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();

                return pizza;
            }

            /// <summary>
            /// This is the Factory method
            /// </summary>
            /// <param name="type"></param>
            /// <returns></returns>
            protected abstract Pizza CreatePizza(PizzaType type);
        }

        private class NyPizzaStore : PizzaStore
        {
            protected override Pizza CreatePizza(PizzaType type)
            {
                var ingredientFactory = new NyPizzaIngredientFactory();

                switch (type)
                {
                    case PizzaType.Cheese:
                        return new NyStyleCheesePizza(ingredientFactory);
                    case PizzaType.Salami:
                        return new NyStyleSalamiPizza(ingredientFactory);
                    default:
                        throw new ArgumentOutOfRangeException(nameof(type), type, null);
                }
            }
        }

        private class ChicagoPizzaStore : PizzaStore
        {
            protected override Pizza CreatePizza(PizzaType type)
            {
                var ingredientFactory = new ChicagoPizzaIngredientFactory();

                switch (type)
                {
                    case PizzaType.Cheese:
                        return new ChicagoStyleCheesePizza(ingredientFactory);
                    case PizzaType.Salami:
                        return new ChicagoStyleSalamiPizza(ingredientFactory);
                    default:
                        throw new ArgumentOutOfRangeException(nameof(type), type, null);
                }
            }
        }

        #endregion

        #region Pizza

        private abstract class Pizza
        {
            protected string Name { private get; set; }
            protected IDough Dough { get; set; }
            protected ISauce Sauce { get; set; }
            protected ICheese Cheese { get; set; }
            protected IClams Clams { get; set; }
            protected IList<IVeggies> Veggies { get; set; } = new List<IVeggies>();

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
                return $"{Environment.NewLine}\tPizza: '{Name}{Environment.NewLine}" +
                       $"\tDough: {(Dough != null ? Dough.GetType().Name : "-")}{Environment.NewLine}" +
                       $"\tSauce: {(Sauce != null ? Sauce.GetType().Name : "-")}{Environment.NewLine}" +
                       $"\tCheese: {(Cheese != null ? Cheese.GetType().Name : "-")}{Environment.NewLine}" +
                       $"\tClams: {(Clams != null ? Clams.GetType().Name : "-")}{Environment.NewLine}" +
                       $"\tVeggies: {string.Join(",", Veggies.Select(x => x.GetType().Name))}'";
            }
        }

        #endregion

        #region NY Style pizza

        private class NyStyleCheesePizza : Pizza
        {
            public NyStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
            {
                Name  = "NY Style Sauce and Cheese pizza";
                Dough = ingredientFactory.CreateDough();
                Sauce = ingredientFactory.CreateSauce();
                Cheese = ingredientFactory.CreateCheese();
                Veggies = ingredientFactory.CreateVeggies();
            }
        }

        private class NyStyleSalamiPizza : Pizza
        {
            public NyStyleSalamiPizza(IPizzaIngredientFactory ingredientFactory)
            {
                Name = "NY Style Sauce and Salami pizza";
                Dough = ingredientFactory.CreateDough();
                Sauce = ingredientFactory.CreateSauce();
                Cheese = ingredientFactory.CreateCheese();
            }
        }

        #endregion

        #region Chicago Style pizza

        private class ChicagoStyleCheesePizza : Pizza
        {
            public ChicagoStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
            {
                Name = "Chicago Style Deep Dish Cheese pizza";
                Dough = ingredientFactory.CreateDough();
                Sauce = ingredientFactory.CreateSauce();
                Cheese = ingredientFactory.CreateCheese();
                Clams = ingredientFactory.CreateClams();
            }

            public override void Cut()
            {
                Console.WriteLine("Cutting the pizza into square slices");
            }
        }

        private class ChicagoStyleSalamiPizza : Pizza
        {
            public ChicagoStyleSalamiPizza(IPizzaIngredientFactory ingredientFactory)
            {
                Name = "Chicago Style Deep Dish Salami pizza";
                Dough = ingredientFactory.CreateDough();
                Cheese = ingredientFactory.CreateCheese();
                Veggies = ingredientFactory.CreateVeggies();
                Clams = ingredientFactory.CreateClams();
            }

            public override void Cut()
            {
                Console.WriteLine("Cutting the pizza into square slices");
            }
        }

        #endregion

        #region Families of Ingredients

        public interface IPizzaIngredientFactory
        {
            IDough CreateDough();
            ISauce CreateSauce();
            ICheese CreateCheese();
            IClams CreateClams();

            IList<IVeggies> CreateVeggies();
        }

        private class NyPizzaIngredientFactory : IPizzaIngredientFactory
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

        private class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
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

        public interface IDough
        {
        }

        public class ThinCrustDough : IDough
        {
        }

        public class ThickCrustDough : IDough
        {
        }


        public interface ISauce
        {
            
        }

        public class MarinaraSauce : ISauce
        {
        }

        public class PlumTomatoSauce : ISauce
        {
        }

        public interface ICheese
        {
            
        }

        public class ReggianoCheese : ICheese
        {
        }

        public class MozarellaCheese : ICheese
        {
        }

        public interface IClams
        {
            
        }

        public class FreshClams : IClams
        {
        }

        public class FrozenClams : IClams
        {
        }

        public interface IVeggies
        {
        }

        public class Garlic : IVeggies
        {
        }

        public class Onion : IVeggies
        {
        }

        public class Mushroom : IVeggies
        {
        }

        #endregion
    }
}