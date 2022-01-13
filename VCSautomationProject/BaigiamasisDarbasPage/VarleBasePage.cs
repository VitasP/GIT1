using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Baigiamasis_darbas
{
    class VarleBasePage
    {
        protected static IWebDriver Driver;

        public VarleBasePage(IWebDriver webdriver)
        {
            Driver = webdriver;
        }
        public void CloseBrowser()
        {
            Driver.Quit();
        }

        public WebDriverWait GetWait(int seconds = 5)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));

            return wait;
        }
        

    }
}
