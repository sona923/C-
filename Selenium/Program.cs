using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    class Program
    {
        //Create the reference for our browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            //Create the reference for our browser
            IWebDriver driver = new ChromeDriver();

            //Navigate to Google page
            driver.Navigate().GoToUrl("http://www.gmail.com");

            //find the element 
            //IWebElement element = driver.FindElement(By.Name("q"));

            //perform the operation
            //element.SendKeys("executeautomation");
            driver.Close();

        }
        //[SetUp]
        public void Initialize()
        {
            //Navigate to Google page
            driver.Navigate().GoToUrl("http://www.gmail.com");
            Console.WriteLine("opened URL");
        }
        //[Test]
        public void ExecuteTesst()
        {
            //find the element 
            IWebElement element = driver.FindElement(By.Name("q"));

            //perform the operation
            element.SendKeys("executeautomation");
            Console.WriteLine("Executed Test");
           

        }
        //[TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed the browser");
            Console.WriteLine("Closed the browser added");
        }


    }
}
