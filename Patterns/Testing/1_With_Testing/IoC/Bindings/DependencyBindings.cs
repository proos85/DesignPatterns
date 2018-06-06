using Ninject.Modules;
using Patterns.Testing._1_With_Testing.Factories.PizzaIngredientsFactories.Chicago;
using Patterns.Testing._1_With_Testing.Factories.PizzaIngredientsFactories.Ny;
using Patterns.Testing._1_With_Testing.PizzaStorePizzaBuilders.Chicago;
using Patterns.Testing._1_With_Testing.PizzaStorePizzaBuilders.Ny;
using Patterns.Testing._1_With_Testing.PizzaStores.Chicago;
using Patterns.Testing._1_With_Testing.PizzaStores.Ny;

namespace Patterns.Testing._1_With_Testing.IoC.Bindings
{
    public class DependencyBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<INyPizzaIngredientFactory>().To<NyPizzaIngredientFactory>();
            Bind<IChicagoPizzaIngredientFactory>().To<ChicagoPizzaIngredientFactory>();

            Bind<INyPizzaStore>().To<NyPizzaStore>();
            Bind<IChicagoPizzaStore>().To<ChicagoPizzaStore>();

            Bind<INyPizzaStorePizzaBuilder>().To<NyPizzaStorePizzaBuilder>();
            Bind<IChicagoPizzaStorePizzaBuilder>().To<ChicagoPizzaStorePizzaBuilder>();

            Bind<IOrderNyStylePizzaExample>().To<OrderNyStylePizzaExample>();
            Bind<IOrderChicagoStylePizzaExample>().To<OrderChicagoStylePizzaExample>();
        }
    }
}