using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject
{
    class _2namudarbai
    {
        private static IWebDriver _driver;

        [TearDown]
        public static void TearDown()
        {
            _driver.Close();
        }


        [TestCase("chrome", "Chrome", TestName = "Test Chrome Browser")]
        [TestCase("firefox", "Firefox", TestName = "Test Firefox Browser")]
        public static void TestBrowser(string browsertype, string expectedResult)
        {

            switch (browsertype)
            {
                case "chrome":
                    _driver = new ChromeDriver();
                    break;
                case "firefox":
                    _driver = new FirefoxDriver();
                    break;
            }

            SetUpWebPage();

            IWebElement resultBlock = _driver.FindElement(By.CssSelector("#primary-detection"));
            Assert.IsTrue(resultBlock.Text.Contains(expectedResult));
        }

        private static void SetUpWebPage()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }




    }
}
