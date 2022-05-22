using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using QAAutomation.Framework;

namespace QAAutomation.Objects
{
    public class Products
    {
        public IWebElement ProductsTitle
        {
            get
            {
                return Driver.Instance.FindElement(By.ClassName("title"));
            }
        }
    }
}
