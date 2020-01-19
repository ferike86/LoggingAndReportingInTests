using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LoggingAndReportingInTests.Tests
{
    [TestFixture]
    public class TestBase
    {
        private ExtentTest _extentTest;

        [SetUp]
        public void BeforeTest()
        {
            _extentTest = ReportWrapper.ExtentReports.CreateTest(TestContext.CurrentContext.Test.Name);
            _extentTest.AssignCategory(TestContext.CurrentContext.Test.ClassName);
        }

        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            Status logStatus;
            string stackTrace = TestContext.CurrentContext.Result.StackTrace ?? string.Empty;

            switch (status)
            {
                case TestStatus.Failed:
                    logStatus = Status.Fail;
                    _extentTest.Log(logStatus, $"Failed: {TestContext.CurrentContext.Result.Message}");
                    break;
                case TestStatus.Warning:
                case TestStatus.Inconclusive:
                    logStatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logStatus = Status.Skip;
                    break;
                default:
                    logStatus = Status.Pass;
                    break;
            }

            _extentTest.Log(logStatus, $"Test finished with status {status} {stackTrace}");
            ReportWrapper.ExtentReports.Flush();
        }
    }
}
