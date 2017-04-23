using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMasterMission
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            var attendu = 3;
            var calcule = 1 + 4;

            Assert.AreNotEqual(attendu, calcule);
        }
    }
}
