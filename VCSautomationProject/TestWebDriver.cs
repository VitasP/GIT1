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
    class TestWebDriver
    {
        [Test]
        public static void TestFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://login.yahoo.com/";
            driver.Close();
        }

        [Test]
        public static void TestYahooPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://login.yahoo.com/";

            IWebElement emailInputField = driver.FindElement(By.Id("login-username"));
            emailInputField.SendKeys("Labas@Labas.lt");
            IWebElement submitButton = driver.FindElement(By.Id("login-signin"));
            submitButton.Click();
            driver.Close();
        }

        [Test]
        public static void TestInputPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement FullNameInputField = driver.FindElement(By.Id("userName"));
            FullNameInputField.SendKeys("Arnas Ratkevicius");

            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();
            IWebElement fullNameResult = driver.FindElement(By.Id("name"));
            Assert.AreEqual("Name:Arnas Ratkevicius", fullNameResult.Text, "Name is Wrong");
            driver.Close();
        }
    }
}
