using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Baigiamasis_darbas
{
    class VarleITRentPage : VarleBasePage
    {
        private const string PageAddress = "https://www.varle.lt/";
        private IWebElement _ITRent => Driver.FindElement(By.CssSelector("body > footer > div > table > tbody > tr:nth-child(1) > td > table > tbody > tr > td:nth-child(4) > a:nth-child(4)"));
        private IWebElement _PCMoreInfo => Driver.FindElement(By.CssSelector("#body > div.outer-container > div > div > div.right-content > div > center > table > tbody > tr:nth-child(3) > td:nth-child(1) > p > a"));
        private IWebElement _PersonInfo => Driver.FindElement(By.CssSelector("#body > div.outer-container > div > div > div.right-content > div > table > tbody > tr > td:nth-child(2) > p:nth-child(4) > a"));
        
        public VarleITRentPage(IWebDriver webdriver) : base(webdriver) { }

        public VarleITRentPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }
        public VarleITRentPage PressITRent()
        {
            _ITRent.Click();
            return this;
        }
        public VarleITRentPage PressPCInfo()
        {
            _PCMoreInfo.Click();
            return this;
        }
        public VarleITRentPage VerifyResult(string expectedResult)
        {
            string testResult = _PersonInfo.Text;
            Assert.IsTrue(_PersonInfo.Text.Contains(expectedResult), "Result is Incorrect");
            return this;
        }
        public VarleITRentPage AcceptCookies()
        {
            Cookie myCookie = new Cookie("CookieConsent",
                "{stamp:%27isdDw/c0pwWX/LsUh7ZNIxK7j7pXFLAJXAGmoOB3UslXAV/Szy8xVA==%27%2Cnecessary:true%2Cpreferences:true%2Cstatistics:true%2Cmarketing:true%2Cver:1%2Cutc:1642090924001%2Cregion:%27lt%27}",
                "www.varle.lt",
                "/",
                DateTime.Now.AddDays(5));

            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();

            return this;
        }
    }
}
