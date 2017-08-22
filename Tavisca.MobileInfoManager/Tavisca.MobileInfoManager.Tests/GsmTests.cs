using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tavisca.MobileInfoManager.Entity;

namespace Tavisca.MobileInfoManager.Tests
{
    [TestClass]
    public class GsmTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calls = new List<Call>();
            Call newCall = new Call();
            calls.Add(newCall);
            calls.Add(new Call());
            var call = new Call();
            calls.Add(call);
            //calls.Remove(newCall);
            //calls.Remove(call);
            calls.Clear();
            //var str = "something";
            //string.
        }
    }
}
