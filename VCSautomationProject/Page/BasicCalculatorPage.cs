using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Page
{
    class BasicCalculatorPage
    {
        private static IWebDriver _driver;

        private IWebElement _firstInput => _driver.FindElement(By.Id("number1Field"));
        private IWebElement _secondInput => _driver.FindElement(By.Id("number2Field"));
        private IWebElement _intOnlyCheckBox => _driver.FindElement(By.Id("integerSelect"));
        private IWebElement _calculateButton => _driver.FindElement(By.Id("calculateButton"));
        private IWebElement _actualResult => _driver.FindElement(By.Id("numberAnswerField"));

        public BasicCalculatorPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        public void EnterFirstInputField(string firstValue)
        {
            _firstInput.Clear();
            _firstInput.SendKeys(firstValue);
        }

        public void EnterSecondInputValue(string secondValue)
        {
            _secondInput.Clear();
            _secondInput.SendKeys(secondValue);
        }

        public void EnterBothValues(string firstValue, string secondValue)
        {
            EnterFirstInputField(firstValue);
            EnterSecondInputValue(secondValue);
        }

        public void CheckIfIntegersOnly(bool shouldBeChecked)
        {
            if (_intOnlyCheckBox.Selected != shouldBeChecked)
            {
                _intOnlyCheckBox.Click();
            }
        }

        public void ClickCalculateButton()
        {
            _calculateButton.Click();
        }

        public void VerifyResult(string result)
        {
            Assert.AreEqual(result, _actualResult.GetAttribute("value"), "Calculation is Incorrect");
        }

    }
}
