using System;
using archtekt2;
using NUnit.Framework;

namespace archtekt2_test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void PassingTest()
        {
            Assert.AreEqual(new double [0], Quadratic.solve(1,0, 1));
        }
    }
}