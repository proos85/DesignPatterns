using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Patterns.Testing._1_With_Testing;
using Patterns.Testing._1_With_Testing.Pizzas;
using Patterns.Testing._1_With_Testing.PizzaStorePizzaBuilders.Ny;

namespace Patterns.Tests
{
    [TestClass]
    // ReSharper disable once InconsistentNaming
    public class OrderNyStylePizzaExample_PlayOrderPizzaExample_Should
    {
        private Mock<INyPizzaStorePizzaBuilder> _nyPizzaStorePizzaBuilder;

        [TestInitialize]
        public void InitializeMocks()
        {
            var mockPizza = new Mock<Pizza>();

            _nyPizzaStorePizzaBuilder = new Mock<INyPizzaStorePizzaBuilder>();

            _nyPizzaStorePizzaBuilder
                .Setup(x => x.CreateBasicPizza(It.IsAny<PizzaType>()))
                .Returns(_nyPizzaStorePizzaBuilder.Object);

            _nyPizzaStorePizzaBuilder
                .Setup(x => x.AddMushrooms())
                .Returns(_nyPizzaStorePizzaBuilder.Object);

            _nyPizzaStorePizzaBuilder
                .Setup(x => x.AddOnions())
                .Returns(_nyPizzaStorePizzaBuilder.Object);

            _nyPizzaStorePizzaBuilder
                .Setup(x => x.BuildPizza())
                .Returns(mockPizza.Object);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Follow_Expected_Logic()
        {
            var sut = new OrderNyStylePizzaExample(_nyPizzaStorePizzaBuilder.Object);
            sut.PlayOrderPizzaExample();
        }
    }
}