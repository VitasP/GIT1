using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Baigiamasis_darbas
{
    class VarleLoginPage : VarleBasePage

    {
        private const string PageAddress = "https://www.varle.lt/";

        private IWebElement _LogIn => Driver.FindElement(By.Id("login_header"));
        private IWebElement _EMail => Driver.FindElement(By.Id("id_username"));
        private IWebElement _Password => Driver.FindElement(By.Id("id_password"));
        private IWebElement _ConfirmLogIn => Driver.FindElement(By.ClassName("button"));
        private IWebElement _ActualResult => Driver.FindElement(By.CssSelector("body > header > div.container.d-flex.align-items-center.justify-content-between > div.hm-icons.d-flex.align-items-center.justify-content-between > div:nth-child(1) > a > p"));


        public VarleLoginPage(IWebDriver webdriver) : base(webdriver) { }

        public VarleLoginPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }
        public VarleLoginPage ClickLogin()
        {
            _LogIn.Click();
            return this;
        }
        public VarleLoginPage InsertEmail(string email)
        {
            _EMail.Clear();
            _EMail.SendKeys(email);
            return this;
        }
        public VarleLoginPage InsertPassword(string password)
        {
            _Password.Clear();
            _Password.SendKeys(password);
            return this;
        }
        public VarleLoginPage ClickConfirmLogin()
        {
            _ConfirmLogIn.Click();
            return this;
        }
        public VarleLoginPage VerifyResult(string expectedResult)
        {
            string testResult = _ActualResult.Text;
            Assert.IsTrue(_ActualResult.Text.Contains(expectedResult), "Result is Incorrect");
            return this;
        }
        
    }
    }
