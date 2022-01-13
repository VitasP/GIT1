using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Baigiamasis_darbas
{
    class VarlePage : VarleBasePage
    {
        private const string PageAddress = "https://www.varle.lt/";

        private IWebElement LogIn => Driver.FindElement(By.Id("login_header"));
        private IWebElement EMail => Driver.FindElement(By.Id("id_username"));
        private IWebElement Password => Driver.FindElement(By.Id("id_password"));
        private IWebElement ConfirmLogIn => Driver.FindElement(By.ClassName("button"));
        private IWebElement Search => Driver.FindElement(By.ClassName("search-input  typeahead tt-input"));
        private IWebElement ConfirmSearch => Driver.FindElement(By.ClassName("search-button"));
        private IWebElement InToBasket => Driver.FindElement(By.CssSelector("body > div:nth-child(3) > div.main > div.right-side > div.ajax-container > div.ajax-content > div.grid.three-in-row.flexible-height-mobile > div.GRID_ITEM > a"));
        private IWebElement ContinueShop => Driver.FindElement(By.CssSelector("#main > div > div.sticky-wrap-sticky-box.sticky-wrap-desktop-sticky-box > div > div.sticky-wrapper > div > div > button"));
        private IWebElement Reviews => Driver.FindElement(By.CssSelector("body > footer > div > table > tbody > tr:nth-child(1) > td > table > tbody > tr > td:nth-child(1) > a:nth-child(7)"));
        private IWebElement Comment => Driver.FindElement(By.Id("id_body"));
        private IWebElement SubmitComment => Driver.FindElement(By.Name("comment-bottom-submit"));
        private IWebElement ITRent => Driver.FindElement(By.CssSelector("body > footer > div > table > tbody > tr:nth-child(1) > td > table > tbody > tr > td:nth-child(4) > a:nth-child(4)"));
        private IWebElement PCMoreInfo => Driver.FindElement(By.CssSelector("#body > div.outer-container > div > div > div.right-content > div > center > table > tbody > tr:nth-child(3) > td:nth-child(1) > p > a"));
        private IWebElement PCRentPerson => Driver.FindElement(By.CssSelector("#body > div.outer-container > div > div > div.right-content > div > table > tbody > tr > td:nth-child(2) > p:nth-child(1) > strong"));
        private IWebElement Help => Driver.FindElement(By.CssSelector("body > footer > div > table > tbody > tr:nth-child(1) > td > table > tbody > tr > td:nth-child(3) > a:nth-child(5)"));
        private IWebElement CompanyDetails => Driver.FindElement(By.CssSelector("#solutions-index-home > div:nth-child(2) > div > section:nth-child(1) > ul > li > div > a"));
        private IWebElement VarleCode => Driver.FindElement(By.CssSelector("#article-body > p:nth-child(4)"));
        public VarlePage(IWebDriver webdriver) : base(webdriver) { }

        public VarlePage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }


    }
}
