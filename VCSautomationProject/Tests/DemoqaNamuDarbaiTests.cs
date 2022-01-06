using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Tests
{
    class DemoqaNamuDarbaiTests
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://demoqa.com/checkbox";
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Close();
        }
        [TestCase("all", "commands", "Commands", TestName ="Test Commands button")]
        [TestCase("desktop", "downloads", "Desktop,Downloads", TestName ="Test Desktop and Downloads button")]
        [TestCase("notes", "general", "Notes,General", TestName = "Test Notes and General button")]

        public static void WhichKeys(string firstInput, string SecondInput, string result)
        {
            
        }
    }
}
