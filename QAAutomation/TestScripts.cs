using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using QAAutomation.Framework;
using QAAutomation.Objects;
using FluentAssertions;

namespace QAAutomation
{
    [TestClass]
    

    public class TestScripts : BaseClass
    {
        [TestMethod]
        [DeploymentItem("chromedriver.exe")]
        public void LoginSwagLabs()
        {
            //USa WebDriverWait en lugar de IWebDriver, puñetas
            
            var loginPage = new LoginPage(30);
            loginPage.UserNameField.SendKeys("standard_user");
            loginPage.PasswordField.SendKeys("secret_sauce");
            loginPage.LoginButton.Click();

            var Products = new Products();
            Products.ProductsTitle.Text.Should().Be("Products");
            
        }

        //[TestMethod]
        //public void FindBackpack()
        //{
        //    driver.Url = "https://www.saucedemo.com/";
        //    driver.Manage().Window.Maximize();
        //    //USa WebDriverWait en lugar de IWebDriver, puñetas
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //    IWebElement userNameField = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("user-name")));
        //    IWebElement passwordField = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
        //    IWebElement loginButton = driver.FindElement(By.Id("login-button"));


        //    userNameField.SendKeys(text: "standard_user");
        //    passwordField.SendKeys(text: "secret_sauce");
        //    loginButton.Click();

        //    IWebElement findBackpack = driver.FindElement(By.LinkText("Sauce Labs Backpack"));
        //    findBackpack.Click();

        //    IWebElement shoppingCart = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("shopping_cart_container")));
        //    IWebElement addToCartButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("add-to-cart-sauce-labs-backpack")));

        //    addToCartButton.Click();
        //    shoppingCart.Click();


        //    IWebElement checkOutButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("checkout")));
        //    checkOutButton.Click();

        //    IWebElement inputFirstName = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("first-name")));
        //    IWebElement inputLastName = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("last-name")));
        //    IWebElement inputPostalCode = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("postal-code")));
        //    inputFirstName.SendKeys("Dave");
        //    inputLastName.SendKeys("Alo");
        //    inputPostalCode.SendKeys("66429");

        //    IWebElement buttonContinue = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("continue")));
        //    buttonContinue.Click();

        //    IWebElement buttonFinish = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("finish")));
        //    buttonFinish.Click();

        //    IWebElement backToProductsButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("back-to-products")));
        //    backToProductsButton.Click();
        //}
    }
}