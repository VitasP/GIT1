using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Baigiamasis_darbas
{
    class VarleBaseTest
    {
        protected static IWebDriver Driver;

        public static VarleLoginPage varleLoginPage;
        public static VarleCartPage varleCartPage;
        public static VarleCommentPage varleCommentPage;
        public static VarleITRentPage varleITRentPage;
        public static VarleHelpPage varleHelpPage;

        [OneTimeSetUp]
        public static void Setup()
        {

            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            varleLoginPage = new VarleLoginPage(Driver);
            varleCartPage = new VarleCartPage(Driver);
            varleCommentPage = new VarleCommentPage(Driver);
            varleITRentPage = new VarleITRentPage(Driver);
            varleHelpPage = new VarleHelpPage(Driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Quit();
        }
    }
}
