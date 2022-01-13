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
    class ND_3_Page : BasePage
    {
        private static IWebDriver _driver;

        private IWebElement ExpandAll => _driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all"));
        private IWebElement Commands => _driver.FindElement(By.CssSelector("#tree-node > div > svg.rct-icon rct-icon-uncheck > Commands"));
        private IWebElement SelectedResult => _driver.FindElement(By.CssSelector("#tree-node > div > span.text-success"));
        private IWebElement Desktop => _driver.FindElement(By.CssSelector("#tree-node > div > svg.rct-icon rct-icon-uncheck > Desktop"));
        private IWebElement Downloads => _driver.FindElement(By.CssSelector("#tree-node > div > svg.rct-icon rct-icon-uncheck > Downloads"));
        private IWebElement Notes => _driver.FindElement(By.CssSelector("#tree-node > div > svg.rct-icon rct-icon-uncheck > Notes"));
        private IWebElement General => _driver.FindElement(By.CssSelector("#tree-node > div > svg.rct-icon rct-icon-uncheck > General"));

        public ND_3_Page(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        public void expandAllButton(bool expandallchecked)
        {
            if (ExpandAll.Selected != expandallchecked)
            {
                ExpandAll.Click();
            }
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

        //destytojo padarytas

        private const string PageAddress = "https://demoqa.com/checkbox";

        private IWebElement _expandAllButton => Driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all"));
        private IWebElement _homeCheckBox => Driver.FindElement(By.CssSelector("#tree-node > ol > li > span > label > span.rct-checkbox > svg"));
        private IWebElement _actualResult => Driver.FindElement(By.Id("result"));
        private IReadOnlyCollection<IWebElement> _checkBoxes => Driver.FindElements(By.ClassName("rct-text"));


        public ND_3_Page(IWebDriver webdriver) : base(webdriver) { }

        public ND_3_Page NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }

        public ND_3_Page ClickExpandAllButton()
        {
            _expandAllButton.Click();

            return this;
        }

        public ND_3_Page DeselectAllCheckBoxes()
        {
            while (!_homeCheckBox.GetAttribute("class").Equals("rct-icon rct-icon-uncheck"))
            {
                _homeCheckBox.Click();
            }

            return this;
        }

        public ND_3_Page ClickOnTwoCheckBoxes(string firstChoice, string secondChoice)
        {
            foreach (IWebElement checkBox in _checkBoxes)
            {
                IWebElement checkboxElement = checkBox.FindElement(By.ClassName("rct-checkbox"));

                if (checkBox.Text.Equals(firstChoice))
                {
                    checkboxElement.Click();
                }
                if (checkBox.Text.Equals(secondChoice))
                {
                    checkboxElement.Click();
                }
            }

            return this;
        }

        public ND_3_Page ClickOnOneCheckBox(string choice)
        {
            foreach (IWebElement checkBox in _checkBoxes)
            {
                IWebElement checkboxElement = checkBox.FindElement(By.ClassName("rct-checkbox"));

                if (checkBox.Text.Equals(choice))
                {
                    checkboxElement.Click();
                }

            }

            return this;
        }

        public ND_3_Page VerifyResults(string expectedResult)
        {
            string testResult = _actualResult.Text;

            Assert.IsTrue(_actualResult.Text.Contains(expectedResult), "Result is Incorrect");

            return this;
        }
    }
}
