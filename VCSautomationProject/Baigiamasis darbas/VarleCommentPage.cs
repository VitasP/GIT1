using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Baigiamasis_darbas
{
    class VarleCommentPage : VarleBasePage
    {
        private const string PageAddress = "https://www.varle.lt/";
        private IWebElement _Reviews => Driver.FindElement(By.CssSelector("body > footer > div > table > tbody > tr:nth-child(1) > td > table > tbody > tr > td:nth-child(1) > a:nth-child(7)"));
        private IWebElement _Comment => Driver.FindElement(By.Id("id_body"));
        private IWebElement _SubmitComment => Driver.FindElement(By.Name("comment-bottom-submit"));
        public VarleCommentPage(IWebDriver webdriver) : base(webdriver) { }

        public VarleCommentPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }

    }
}
