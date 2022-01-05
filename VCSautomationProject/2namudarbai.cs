using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Close();
        }

        [TestCase( true, TestName = "narsykleChrome")]
        [TestCase( false, TestName = "narsykleNeFirefox")]

        public static void Narsykle(bool operatingSystem, string result)
        {
            
            IWebElement intOperating = _driver.FindElement(By.Id("parse-controls"));
            intOperating.Click();
            IWebElement actualResult = _driver.FindElement(By.Id("primary-detection"));
            if (operatingSystem)
            {
                intOperating.Click();
            }
            Assert.AreEqual("Chrome 96 on Windows 10", result);



        }



    }
}
