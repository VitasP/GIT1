using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Page
{
    class DemoqaNamuDarbaiPage
    {
        private static IWebDriver _driver;

        private IWebElement ExpandAll => _driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all"));
        private IWebElement Commands => _driver.FindElement(By.CssSelector("#tree-node > div > svg.rct-icon rct-icon-uncheck > Commands"));
        private IWebElement SelectedResult => _driver.FindElement(By.CssSelector("#tree-node > div > span.text-success"));
        private IWebElement Desktop => _driver.FindElement(By.CssSelector("#tree-node > div > svg.rct-icon rct-icon-uncheck > Desktop"));
        private IWebElement Downloads => _driver.FindElement(By.CssSelector("#tree-node > div > svg.rct-icon rct-icon-uncheck > Downloads"));
        private IWebElement Notes => _driver.FindElement(By.CssSelector("#tree-node > div > svg.rct-icon rct-icon-uncheck > Notes"));
        private IWebElement General => _driver.FindElement(By.CssSelector("#tree-node > div > svg.rct-icon rct-icon-uncheck > General"));

        public DemoqaNamuDarbaiPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        public void expandAllButton()
        {
            ExpandAll.Click();
        }
        public void commandsButton(bool commandschecked)
        {
            if (Commands.Selected != commandschecked)
            {
                Commands.Click();
            }
        }
        public void desktopButton(bool desktopchecked)
        {
            if (Desktop.Selected != desktopchecked)
            {
                Desktop.Click();
            }
        }
        public void downloadsButton(bool downloadschecked)
        {
            if (Downloads.Selected != downloadschecked)
            {
                Downloads.Click();
            }    
        }
        public void NotesButton(bool noteschecked)
        {
            if (Notes.Selected != noteschecked)
            {
                Notes.Click();
            }
        }
        public void GeneralButton(bool generalchecked)
        {
            if (General.Selected != generalchecked)
            {
                General.Click();
            }
        }
        public void selectedResultButton(string result)
        {
            Assert.AreEqual(result, SelectedResult.GetAttribute("value"), "wrong");
        }
    }
}
