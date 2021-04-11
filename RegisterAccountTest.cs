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
[TestFixture]
public class RegisterAccountTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), new ChromeOptions().ToCapabilities());
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void registerAccount() {
    driver.Navigate().GoToUrl("http://localhost:4200/login");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.CssSelector(".registerLink")).Click();
    driver.FindElement(By.CssSelector(".firstname")).Click();
    driver.FindElement(By.CssSelector(".firstname")).SendKeys("Jack");
    driver.FindElement(By.CssSelector(".lastname")).SendKeys("Reilly");
    driver.FindElement(By.CssSelector(".username")).SendKeys("jackreilly@gmail.com");
    driver.FindElement(By.CssSelector(".password")).SendKeys("testpass");
    driver.FindElement(By.CssSelector(".avatar")).SendKeys("testavatar");
    driver.FindElement(By.CssSelector(".login")).Click();
  }
}
