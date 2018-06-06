using System;

namespace Patterns.Testing._1_With_Testing
{
    public static class Example
    {
        public static void Run()
        {
            // Let's order a NY style pizza
            OrderNyStylePizza();

            Console.WriteLine();

            // And a chicago style pizza
            OrderChicagoStylePizza();

            Console.ReadKey();
        }

        private static void OrderNyStylePizza()
        {
            IoC.DependencyContainer.Instance.GetInstance<IOrderNyStylePizzaExample>().PlayOrderPizzaExample();
        }

        private static void OrderChicagoStylePizza()
        {
            IoC.DependencyContainer.Instance.GetInstance<IOrderChicagoStylePizzaExample>().PlayOrderPizzaExample();
        }
    }
}