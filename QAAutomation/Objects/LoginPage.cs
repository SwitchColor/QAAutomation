using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using QAAutomation.Framework;



namespace QAAutomation.Objects
{
    public class LoginPage
    {
        private int defaultWaitTime;

        public LoginPage(int defaultWaitTime)
        {
            this.defaultWaitTime = defaultWaitTime;
        }

        public IWebElement UserNameField
        {
            get
            {
                return Driver.Instance.FindElement(By.Id("user-name"));
            }
        }
        public IWebElement PasswordField
        {
            get
            {
                return Driver.Instance.FindElement(By.Id("password"));
            }
        }
        public IWebElement LoginButton
        {
            get
            {
                return Driver.Instance.FindElement(By.Id("login-button"));
            }
        }

        public void SignIn(string userName, string password)
        {
            UserNameField.SendKeys(userName + Keys.Tab);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }
    }
}
