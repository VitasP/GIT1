using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Page
{
    class SenukaiPage : BasePage
    {
        private const string PageAddress = "https://www.senukai.lt/";
        public SenukaiPage(IWebDriver webdriver) : base(webdriver) { }

        public SenukaiPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }
        public SenukaiPage AcceptCookies()
        {
            Cookie myCookie = new Cookie("CookieConsent");
        }
    }
}
