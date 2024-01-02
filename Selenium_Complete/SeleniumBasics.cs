using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Threading;

namespace Selenium_Complete
{
    [TestClass]
    public class SeleniumBasics
    {
        [TestMethod]
        public void LaunchBrowser()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.facebook.com";

            driver.Quit();
        }

        [TestMethod]
        public void GetTitleURLPageSource()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com";
            Console.WriteLine(driver.Title);
            Thread.Sleep(1000);
            Console.WriteLine(driver.Url);
            Thread.Sleep(1000);
            Console.WriteLine(driver.PageSource);
            Thread.Sleep(1000);
            driver.Quit();
        }
        [TestMethod]
        public void Fullscreen()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.Manage().Window.FullScreen();
            Thread.Sleep(2000);
            driver.Manage().Window.Minimize();
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void GetAndSetThePosition()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";
            Thread.Sleep(3000);
            driver.Manage().Window.Position = new Point(200, 200);
            Thread.Sleep(3000);

            Point pt = driver.Manage().Window.Position;

            Console.WriteLine(pt);

            driver.Quit();

        }
        [TestMethod]
        public void GetAndSetTheSize()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";
            Thread.Sleep(3000);
            driver.Manage().Window.Size = new Size(400, 200);
            Thread.Sleep(3000);
            Size size = driver.Manage().Window.Size;
            Console.WriteLine(size);
            driver.Quit();
        }
        [TestMethod]
        public void Navigate()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com";
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://www.instagram.com");
            Thread.Sleep(3000);
            driver.Navigate().Back();
            Thread.Sleep(3000);
            driver.Navigate().Forward();
            Thread.Sleep(3000);
            driver.Navigate().Refresh();
            Thread.Sleep(3000);
            driver.Quit();
        }
        [TestMethod]
        public void HandelCheckbox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://formstone.it/components/checkbox/";

            //driver.FindElement(By.XPath("//input[@id='checkbox-2']")).Click();
            //driver.FindElement(By.XPath("//div[@class='fs-checkbox fs-light']")).Click();

            ReadOnlyCollection<IWebElement> webElements = driver.FindElements(By.XPath("//input[@type='checkbox']"));
            int checkedCount = 0; int uncheckedCount = 0;
            foreach (IWebElement element in webElements)
            {
                if (element.Selected == true)
                {
                    checkedCount++;
                }
                else
                {
                    uncheckedCount++;
                }
            }
            Console.WriteLine(checkedCount);
            Console.WriteLine(uncheckedCount);
            driver.Quit();
        }
    }       
}

