// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace SeleniumProject
{
    [TestFixture]
    public class CreateAdTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver("C:\\selenium\\Chrome");
            //http://localhost:4444/wd/hub
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void createAd()
        {
            driver.Navigate().GoToUrl("http://localhost:4200/login");
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
            driver.FindElement(By.CssSelector(".username")).Click();
            driver.FindElement(By.CssSelector(".username")).SendKeys("jackreilly@gmail.com");
            driver.FindElement(By.CssSelector(".password")).SendKeys("testpass");
            driver.FindElement(By.CssSelector(".login")).Click();
            driver.FindElement(By.CssSelector(".svg-inline--fa")).Click();
            driver.FindElement(By.CssSelector(".ng-untouched:nth-child(1)")).Click();
            driver.FindElement(By.CssSelector(".ng-dirty")).SendKeys("TestAd");
            driver.FindElement(By.CssSelector(".ng-untouched:nth-child(2)")).SendKeys("Post deployment testing ad");
            driver.FindElement(By.CssSelector(".ng-untouched")).SendKeys("testAdUrl");
            driver.FindElement(By.CssSelector(".createAd")).Click();
            driver.FindElement(By.CssSelector(".swal2-confirm")).Click();
        }
    }
}
