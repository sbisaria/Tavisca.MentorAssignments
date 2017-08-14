using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tavisca.MobileInfoManager.Entity;

namespace Tavisca.MobileInfoManager.Tests
{
    [TestClass]
    public class BatteryCharactersticsTests
    {
        [TestMethod]
        public void BatteryCharactersticsTest()
        {
            var batteryCharacterstics = new BatteryCharacterstics(0.0,0.0,"Li-Ion");
            var abc = batteryCharacterstics.ToString();
            Assert.AreEqual(abc, 
                "Idle hours: " + batteryCharacterstics.IdleHours + 
                "Talk hours: " + batteryCharacterstics.TalkHours + 
                "Battery model: " + batteryCharacterstics.BatteryModel);
            Assert.AreEqual(batteryCharacterstics.BatteryType, BatteryType.Li_Ion);
        }
       
    }
}
