using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSautomationProject.Tools;

namespace VCSautomationProject.Baigiamasis_darbas
{
    class VarleCommentPage : VarleBasePage
    {
        private const string PageAddress = "https://www.varle.lt/";
        private IWebElement _Reviews => Driver.FindElement(By.CssSelector("body > footer > div > table > tbody > tr:nth-child(1) > td > table > tbody > tr > td:nth-child(1) > a:nth-child(7)"));
        private IWebElement _Comment => Driver.FindElement(By.Id("id_body"));
        private IWebElement _SubmitComment => Driver.FindElement(By.Name("comment-bottom-submit"));
        private IWebElement _BaseComments => Driver.FindElement(By.CssSelector("#body > div.outer-container > div > div.box1 > div.tabs-container > ul > li.active > a > span"));
        private IWebElement _CheckComment => Driver.FindElement(By.XPath("//*[text()='geras aptarnavimas']"));
        public VarleCommentPage(IWebDriver webdriver) : base(webdriver) { }

        public VarleCommentPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }
        public VarleCommentPage ClickReviews()
        {
            _Reviews.Click();
            return this;
        }
        public VarleCommentPage InputComment(string value)
        {
            _Comment.SendKeys(value);
            return this;
        }
        public VarleCommentPage PublishComment()
        {
            _SubmitComment.Click();
            return this;
        }
        public VarleCommentPage PressBaseComments()
        {
            _BaseComments.Click();
            return this;
        }
        public VarleCommentPage VerifyComment(string expectedResult)
        {
            try
            {
                string testResult = _CheckComment.Text;
            }
            catch (NoSuchElementException e) {
                MyScreenshot.TakeScreenshot(Driver);
            }
            Assert.IsFalse(_CheckComment.Text.Contains(expectedResult), "Result is Incorrect");
            return this;
        }
        public VarleCommentPage AcceptCookies()
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
