using NUnit.Framework;
using OpenQA.Selenium;
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
        private IWebElement _Search => Driver.FindElement(By.ClassName("search-input  typeahead tt-input"));
        private IWebElement _ConfirmSearch => Driver.FindElement(By.ClassName("search-button"));
        private IWebElement _InToBasket => Driver.FindElement(By.CssSelector("body > div:nth-child(3) > div.main > div.right-side > div.ajax-container > div.ajax-content > div.grid.three-in-row.flexible-height-mobile > div.GRID_ITEM > a"));
        private IWebElement _ContinueShop => Driver.FindElement(By.CssSelector("#main > div > div.sticky-wrap-sticky-box.sticky-wrap-desktop-sticky-box > div > div.sticky-wrapper > div > div > button"));
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
            _Search.Click();
            _Search.SendKeys(item);
            return this;
        }
        public VarleCartPage PressSearch()
        {
            _ConfirmSearch.Click();
            return this;
        }
        public VarleCartPage ToBasket()
        {
            _InToBasket.Click();
            return this;
        }
        public VarleCartPage Continue()
        {
            _ContinueShop.Click();
            return this;
        }
        public VarleCartPage VerifyCart(string expectedResult)
        {
            string testResult = _Result.Text;
            Assert.IsTrue(_Result.Text.Contains(expectedResult), "Result is Incorrect");
            return this;
        }

    }
}
