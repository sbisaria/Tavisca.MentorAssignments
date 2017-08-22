using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PizzaOrderingSystem.Tests
{
    [TestClass]
    public class PizzaFixture
    {
        [TestMethod]
        public void AddType_works_correctly()
        {
            Pizza pizza = new Pizza();
            pizza.Type.Add("Veg");
            pizza.Type.Add("Non-Veg");
        }

    }
}
