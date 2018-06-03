using System;

namespace Patterns.Factories._1_Creating_Basic_Pizza
{
    public static class Example
    {
        public static void Run()
        {
            var pizzaStore = new PizzaStore();
            pizzaStore.OrderPizza(PizzaType.Greek);
            Console.ReadKey();
        }

        #region PizzaType

        enum PizzaType
        {
            Cheese,
            Salami,
            Greek
        }

        #endregion

        #region PizzaStore

        private class PizzaStore
        {
            public Pizza OrderPizza(PizzaType type)
            {
                Pizza pizza;

                switch (type)
                {
                    case PizzaType.Cheese:
                        pizza = new CheesePizza();
                        break;
                    case PizzaType.Salami:
                        pizza = new SalamiPizza();
                        break;
                    case PizzaType.Greek:
                        pizza = new GreekPizza();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();

                return pizza;
            }
        }

        #endregion

        #region Pizza

        private abstract class Pizza
        {
            public void Prepare()
            {
                Console.WriteLine("Prepare the pizza");
            }

            public void Bake()
            {
                Console.WriteLine("Bake the pizza");
            }

            public void Cut()
            {
                Console.WriteLine("Cut the pizza");
            }

            public void Box()
            {
                Console.WriteLine("Box the pizza");
            }
        }

        #endregion

        #region CheesePizza

        private class CheesePizza : Pizza
        {
        }

        #endregion

        #region SalamiPizza

        private class SalamiPizza : Pizza
        {
        }

        #endregion

        #region GreekPizza

        private class GreekPizza : Pizza
        {
        }

        #endregion
    }
}