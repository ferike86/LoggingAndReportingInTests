using LoggingAndReportingInTests.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingAndReportingInTests.Tests
{
    [TestFixture]
    public class LoginTests: TestBase
    {
        [Test]
        public void LoginTest()
        {
            new FakeLoginPageObject().Login("username", "password");
        }

        [Test]
        public void LoginTestAssertionFailed()
        {
            Assert.Fail("Something went wrong");
        }

        [Test]
        public void LoginTestExceptionThrown()
        {
            throw new Exception("Exception during test execution");
        }

        [Test]
        [Ignore("Test not finished yet")]
        public void LoginTestSkipped()
        {
        }

        [Test]
        public void LoginTestWaring()
        {
            Assert.Warn("Some warning");
        }
    }
}
