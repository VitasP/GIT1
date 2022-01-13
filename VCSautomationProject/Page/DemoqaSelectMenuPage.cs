using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Page
{
    class DemoqaSelectMenuPage : BasePage
    {
        private const string PageAddress = "https://demoqa.com/select-menu";

        private SelectElement _dropDown => new SelectElement(Driver.FindElement(By.Id("oldSelectMenu")));
        private SelectElement _multiDropDown => new SelectElement(Driver.FindElement(By.Id("cars")));

        public DemoqaSelectMenuPage(IWebDriver webdriver) : base(webdriver) { }

        public DemoqaSelectMenuPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }

        public DemoqaSelectMenuPage SelectFromDropdownByText(string text)
        {
            _dropDown.SelectByText(text);

            return this;
        }

        public DemoqaSelectMenuPage SelectFromDropDownByValue(string value)
        {
            _dropDown.SelectByValue(value);

            return this;
        }

        public DemoqaSelectMenuPage VerifySingleSelectResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, _dropDown.SelectedOption.Text, $"Selected color is incorect. Expected color is {expectedResult}");

            return this;
        }

        public DemoqaSelectMenuPage SelectMultiDropDown(List<string> elements)
        {
            Actions action = new Actions(Driver);

            action.KeyDown(Keys.LeftControl);

            foreach (IWebElement selectElement in _multiDropDown.Options)
            {
                foreach (string element in elements)
                {
                    if (element.Equals(selectElement.Text))
                    {
                        _multiDropDown.SelectByText(element);
                    }
                }
            }

            action.KeyUp(Keys.LeftControl);
            action.Build().Perform();

            return this;
        }

        public DemoqaSelectMenuPage VerifyMultiSelectDropDown(string expectedResult)
        {
            IList<IWebElement> options = _multiDropDown.AllSelectedOptions;

            foreach (IWebElement option in options)
            {
                Assert.IsTrue(expectedResult.Contains(option.Text), "Selected Wrong value");
            }

            return this;
        }
    }
}
