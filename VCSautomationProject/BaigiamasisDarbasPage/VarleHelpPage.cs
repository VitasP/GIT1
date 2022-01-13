using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Baigiamasis_darbas
{
    class VarleHelpPage : VarleBasePage
    {
        private const string PageAddress = "https://www.varle.lt/";

        private IWebElement _LeaveMessage => Driver.FindElement(By.CssSelector("body > header > div.top-header > div > div.top-menu-center.d-flex.justify-content-center.align-items-center > span > a"));
        private IWebElement _Help => Driver.FindElement(By.CssSelector("body > footer > div > table > tbody > tr:nth-child(1) > td > table > tbody > tr > td:nth-child(3) > a:nth-child(5)"));
        private IWebElement _CompanyDetails => Driver.FindElement(By.CssSelector("#solutions-index-home > div:nth-child(2) > div > section:nth-child(1) > ul > li > div > a"));
        private IWebElement _VarleCode => Driver.FindElement(By.CssSelector("#article-body > p:nth-child(4)"));
        private IWebElement _VarleEmail => Driver.FindElement(By.CssSelector("#article-body > p:nth-child(9) > a"));
        


        public VarleHelpPage(IWebDriver webdriver) : base(webdriver) { }

        public VarleHelpPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }
        public VarleHelpPage PressOnMessage()
        {
            _LeaveMessage.Click();
            return this;
        }
        public VarleHelpPage NavigateToHelp()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(_Help));
            _Help.Click();
            return this;
        }
        public VarleHelpPage NavigateToCompany()
        {
            _CompanyDetails.Click();
            return this;
        }
        public VarleHelpPage VerifyCodeandEmail(string valueCode, string valueEmail)
        {
            string testCResult = _VarleCode.Text;
            string testEResult = _VarleEmail.Text;
            Assert.IsTrue(_VarleCode.Text.Contains(valueCode), "Result is Incorrect");
            Assert.IsTrue(_VarleEmail.Text.Contains(valueEmail), "Result is Incorrect");
            return this;
        }

        public VarleHelpPage AcceptCookies()
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
