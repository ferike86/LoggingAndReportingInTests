using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingAndReportingInTests.Tests
{
    [TestFixture]
    class LogoutTests : TestBase
    {
        [Test]
        public void PassingTest()
        {
            Assert.Pass();
        }
    }
}
