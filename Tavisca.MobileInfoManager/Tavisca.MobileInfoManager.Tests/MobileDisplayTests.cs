using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tavisca.MobileInfoManager.Entity;
using System.Collections.Generic;

namespace Tavisca.MobileInfoManager.Tests
{
    [TestClass]
    public class MobileDisplayTests
    {
        [TestMethod]
        public void Test_constructor_with_two_parameters()
        {
            var mobileDisplay = new MobileDisplay("",new List<string>());
        }
    }
}
