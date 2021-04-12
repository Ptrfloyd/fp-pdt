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
            

            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("Dublin Business School");
            driver.SwitchTo().Frame(0);
            driver.FindElement(By.CssSelector("#introAgreeButton > span > span")).Click();

            driver.FindElement(By.Name("btnK")).Click();
            driver.FindElement(By.CssSelector("div:nth-child(2) > .tF2Cxc:nth-child(2) .LC20lb")).Click();
            driver.FindElement(By.Id("usrCtrl_Hide")).Click();
            driver.FindElement(By.LinkText("Courses")).Click();
        }
    }
}
