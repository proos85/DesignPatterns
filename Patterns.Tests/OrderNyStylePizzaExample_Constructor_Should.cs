using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Patterns.Testing._1_With_Testing;
using Patterns.Testing._1_With_Testing.PizzaStorePizzaBuilders.Ny;

namespace Patterns.Tests
{
    [TestClass]
    // ReSharper disable once InconsistentNaming
    public class OrderNyStylePizzaExample_Constructor_Should
    {
        private INyPizzaStorePizzaBuilder _nyPizzaStorePizzaBuilder;

        [TestInitialize]
        public void InitializeMocks()
        {
            _nyPizzaStorePizzaBuilder = new Mock<INyPizzaStorePizzaBuilder>().Object;
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Create_Instance_Of_Type()
        {
            var sut = new OrderNyStylePizzaExample(_nyPizzaStorePizzaBuilder);
            Assert.IsInstanceOfType(sut, typeof(OrderNyStylePizzaExample));
        }
    }
}