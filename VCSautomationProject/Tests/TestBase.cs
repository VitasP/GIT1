using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSautomationProject.Page;
using VCSautomationProject.Tools;

namespace VCSautomationProject.Tests
{
    class TestBase
    {
        protected static IWebDriver Driver;

        public static ND_3_Page nd_3_Page;
        public static DemoqaTextBoxPage demoqaTextBoxPage;
        public static DemoqaSelectMenuPage demoqaSelectMenuPage;
        public static AlertPage alertPage;

        [OneTimeSetUp]
        public static void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            
            demoqaTextBoxPage = new DemoqaTextBoxPage(Driver);
            demoqaSelectMenuPage = new DemoqaSelectMenuPage(Driver);
            alertPage = new AlertPage(Driver);
        }


        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Driver.Quit();
        }

        [TearDown]
        public static void TearDown()
        {
            if(TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(Driver);
            }

        }
    }
}
