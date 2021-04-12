using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class Program
    {
        static void Main(string[] args)
        {           
            
            IWebDriver driver = new ChromeDriver("C:\\selenium\\Chrome");

            driver.Navigate().GoToUrl("http://localhost:4200/login");
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
            //driver.FindElement(By.CssSelector("#introAgreeButton > span > span")).Click();
            driver.FindElement(By.CssSelector(".registerLink")).Click();
            driver.FindElement(By.CssSelector(".firstname")).Click();
            driver.FindElement(By.CssSelector(".firstname")).SendKeys("Jack");
            driver.FindElement(By.CssSelector(".lastname")).SendKeys("Reilly");
            driver.FindElement(By.CssSelector(".username")).SendKeys("jockreilly@gmail.com");
            driver.FindElement(By.CssSelector(".password")).SendKeys("testpass");
            driver.FindElement(By.CssSelector(".avatar")).SendKeys("testavatar");
            driver.FindElement(By.CssSelector(".login")).Click();
        }
    }
}
