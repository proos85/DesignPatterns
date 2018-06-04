using System;

namespace Patterns.Factories._2_Simple_Factory
{
    public static class Example
    {
        public static void Run()
        {
            var factory = new SimplePizzaFactory();
            var pizzaStore = new PizzaStore(factory);
            pizzaStore.OrderPizza(PizzaType.Veggie);
            Console.ReadKey();
        }

        #region PizzaType

        enum PizzaType
        {
            Cheese,
            Salami,
            Clam,
            Veggie
        }

        #endregion

        #region PizzaStore

        private class PizzaStore
        {
            private readonly SimplePizzaFactory _factory;

            public PizzaStore(SimplePizzaFactory factory)
            {
                _factory = factory;
            }

            public Pizza OrderPizza(PizzaType type)
            {
                var pizza = _factory.CreatePizza(type);
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();

                return pizza;
            }
        }

        #endregion

        #region SimplePizzaFactory

        class SimplePizzaFactory
        {
            public Pizza CreatePizza(PizzaType type)
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
                    case PizzaType.Veggie:
                        pizza = new VeggiePizza();
                        break;
                    case PizzaType.Clam:
                        pizza = new ClamPizza();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

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

        #region VeggiePizza

        private class VeggiePizza : Pizza
        {
        }

        #endregion

        #region ClamPizza

        private class ClamPizza : Pizza
        {
        }

        #endregion
    }
}