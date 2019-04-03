using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
namespace Selenium_practice
{

    public class Class1
    {
       
        
        
        //[SetUp]
        //public void setup()
        //{
        //    Webdriver.Navigate().GoToUrl("https://localhost:44302/counter");
        //}
        //[TearDown]
        //public void Dispose()
        //{
        //    Webdriver.Quit();

        //}
        // To verify the number of times user can 
        [Test]
        public void Test1()
        {
            //test
            IWebDriver Webdriver = new ChromeDriver();
            Webdriver.Navigate().GoToUrl("https://localhost:44302/counter");
            Webdriver.FindElement(By.XPath("//a[@ng-reflect-router-link='/counter']")).Click();
            IWebElement ele = Webdriver.FindElement(By.XPath("//button[text()='Increment']"));
            for (int i=0; i <= 5; i++)
            {
                ele.Click();
            }
           // Webdriver.FindElement(By.XPath("//button[text()='Increment']")).Click();
           string CurrentCount= Webdriver.FindElement(By.XPath("//p[text()='Current count: ']/strong")).Text.ToString();
            //li/a[@href="/counter"]
            TestContext.Out.WriteLine("Performed click action:" + CurrentCount);
        }
    }
}
