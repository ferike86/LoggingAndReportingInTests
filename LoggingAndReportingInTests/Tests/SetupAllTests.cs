using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace LoggingAndReportingInTests.Tests
{
    [SetUpFixture]
    public class SetupAllTests
    {
        [OneTimeSetUp]
        public void SetupOnce()
        {
            ReportWrapper.ExtentReports = new AventStack.ExtentReports.ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "report.html"));
            htmlReporter.Config.ReportName = "Logging and Reporting in Tests";
            htmlReporter.Config.DocumentTitle = "Logging and Reporting in Tests";
            ReportWrapper.ExtentReports.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void CleanOnce()
        {
            ReportWrapper.ExtentReports.Flush();
        }
    }
}
