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
    class VarleCartPage : VarleBasePage
    {
        private const string PageAddress = "https://www.varle.lt/";
        private IWebElement _Search => Driver.FindElement(By.CssSelector("body > header > div.container.d-flex.align-items-center.justify-content-between > div.search > form > span > input.search-input.typeahead.tt-input"));
        private IWebElement _ConfirmSearch => Driver.FindElement(By.ClassName("search-button"));
        private IWebElement _OpenProduct => Driver.FindElement(By.CssSelector("body > div:nth-child(3) > div.main > div.right-side > div.ajax-container > div.ajax-content > div.grid.three-in-row.flexible-height-mobile > div.GRID_ITEM > div.img-container > a:nth-child(1)"));
        private IWebElement _InToBasket => Driver.FindElement(By.Id("order-button"));
        private IWebElement _ContinueShop => Driver.FindElement(By.CssSelector("#add_to_basket_popup > a"));
        private IWebElement _Result => Driver.FindElement(By.CssSelector("body > header > div.container.d-flex.align-items-center.justify-content-between > div.hm-icons.d-flex.align-items-center.justify-content-between > div:nth-child(3) > a > span"));
        public VarleCartPage(IWebDriver webdriver) : base(webdriver) { }

        public VarleCartPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }
        public VarleCartPage InputSearch(string item)
        {
            _Search.SendKeys(item);
            return this;
        }
        public VarleCartPage PressSearch()
        {
            _ConfirmSearch.Click();
            return this;
        }
        public VarleCartPage ToProduct()
        {
            _OpenProduct.Click();
            return this;
        }
        public VarleCartPage ToBasket()
        {
            _InToBasket.Click();
            return this;
        }
        public VarleCartPage Continue()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementToBeClickable(_ContinueShop));
            Driver.SwitchTo().Frame(0);
            Driver.SwitchTo().ActiveElement().FindElement(By.Id("add_to_basket_popup")).Click();
            _ContinueShop.Click();
            return this;
        }
        public VarleCartPage VerifyCart(string expectedResult)
        {
            string testResult = _Result.Text;
            Assert.IsTrue(_Result.Text.Contains(expectedResult), "Result is Incorrect");
            return this;
        }

        public VarleCartPage AcceptCookies()
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
