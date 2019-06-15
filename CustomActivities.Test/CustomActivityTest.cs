using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomActivities.Test
{
    [TestClass]
    public class CustomActivityTest
    {
        [TestMethod]
        public void ConcatString()
        {
            CustomActivities.ConcateStringActivity activity = new ConcateStringActivity();
            var result = activity.ConcatString("first", "second");
            Assert.AreEqual(result, "first second");
        }
    }
}
