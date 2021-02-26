using Microsoft.VisualStudio.TestTools.UnitTesting;
using GFSS_One;
using System;
using System.Collections.Generic;
using System.Text;

namespace GFSS_One.Tests
{
    [TestClass()]
    public class ECC_OhmCalculatorTests
    {

        private static ECC_OhmCalculator ohmCalculator;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            ohmCalculator = new ECC_OhmCalculator(new ECC_ColorCodeParser());
        }

        [TestMethod()]
        public void CalculateOhmValueTest_Positive()
        {
            var ohm47 = ohmCalculator.CalculateOhmValue("Yellow", "Violet", "Black");
            Assert.AreEqual(ohm47, 47);

            // Incrementing Decimal power by one
            var ohm470 = ohmCalculator.CalculateOhmValue("Yellow", "Violet", "Brown");
            Assert.AreEqual(ohm470, 470);

            // Changing string capitalization should have no affect
            Assert.AreEqual(ohmCalculator.CalculateOhmValue("YelloW", "VIOLET", "brown"), ohmCalculator.CalculateOhmValue("yellOW", "violet", "bRown"));
        }

        [TestMethod()]
        public void CalculateOhmValueTest_Negative()
        {
            try
            {
                var ohm47 = ohmCalculator.CalculateOhmValue("Yellow", "Violet", "Purple");
                Assert.Fail("Should have thrown an exception on Purple");
            } catch (Exception ex)
            {
                if (!ex.Message.Contains("Purple")) Assert.Fail("Should have thrown an exception on Purple");
            }

        }
    }
}