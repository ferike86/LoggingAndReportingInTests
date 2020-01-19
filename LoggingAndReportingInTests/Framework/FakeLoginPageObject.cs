using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingAndReportingInTests.Framework
{
    public class FakeLoginPageObject
    {
        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger(); 

        public FakeLoginPageObject()
        {
            _logger.Debug($"{nameof(FakeLoginPageObject)} created");
        }

        public void EnterUsername(string username)
        {
            _logger.Info($"Username entered: {username}");
        }

        public void EnterPassword(string password)
        {
            _logger.Info($"Password entered: {password}");
        }

        public void ClickLoginButton()
        {
            _logger.Info("Login button clicked");
        }

        public void Login(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLoginButton();
        }
    }
}
