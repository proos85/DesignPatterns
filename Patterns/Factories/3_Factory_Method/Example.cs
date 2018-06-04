using System;
using System.Collections.Generic;

namespace Patterns.Factories._3_Factory_Method
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
                switch (type)
                {
                    case PizzaType.Cheese:
                        return new NyStyleCheesePizza();
                    case PizzaType.Salami:
                        return new NyStyleSalamiPizza();
                    default:
                        throw new ArgumentOutOfRangeException(nameof(type), type, null);
                }
            }
        }

        private class ChicagoPizzaStore : PizzaStore
        {
            protected override Pizza CreatePizza(PizzaType type)
            {
                switch (type)
                {
                    case PizzaType.Cheese:
                        return new ChicagoStyleCheesePizza();
                    case PizzaType.Salami:
                        return new ChicagoStyleSalamiPizza();
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
            protected string Dough { private get; set; }
            protected string Sauce { private get; set; }
            protected List<string> Toppings { get; } = new List<string>();

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
                return $"Pizza: '{Name}; {Dough}; {Sauce}; {string.Join(",", Toppings)}'";
            }
        }

        #endregion

        #region NY Style pizza

        private class NyStyleCheesePizza : Pizza
        {
            public NyStyleCheesePizza()
            {
                Name  = "NY Style Sauce and Cheese pizza";
                Dough = "Thin crust Dough";
                Sauce = "Marinara Sauce";
                Toppings.Add("Grated Reggiano Cheese");
            }
        }

        private class NyStyleSalamiPizza : Pizza
        {
            public NyStyleSalamiPizza()
            {
                Name = "NY Style Sauce and Salami pizza";
                Dough = "Thin crust Dough";
                Sauce = "Marinara Sauce";
                Toppings.Add("Slices of Salami");
            }
        }

        #endregion

        #region Chicago Style pizza

        private class ChicagoStyleCheesePizza : Pizza
        {
            public ChicagoStyleCheesePizza()
            {
                Name = "Chicago Style Deep Dish Cheese pizza";
                Dough = "Extra Thick Crust Dough";
                Sauce = "Plum Tomato Sauce";
                Toppings.Add("Shredded Mozzarella Cheese");
            }

            public override void Cut()
            {
                Console.WriteLine("Cutting the pizza into square slices");
            }
        }

        private class ChicagoStyleSalamiPizza : Pizza
        {
            public ChicagoStyleSalamiPizza()
            {
                Name = "Chicago Style Deep Dish Cheese pizza";
                Dough = "Extra Thick Crust Dough";
                Sauce = "Plum Tomato Sauce";
                Toppings.Add("Fat Slices of Salami");
            }

            public override void Cut()
            {
                Console.WriteLine("Cutting the pizza into square slices");
            }
        }

        #endregion
    }
}