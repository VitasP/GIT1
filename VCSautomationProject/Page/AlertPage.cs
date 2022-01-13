using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Page
{
    class AlertPage : BasePage
    {
        private const string PageAddress = "https://demoqa.com/alerts";
        private const string YouSelectedText = "You selected ";
        private const string YouEnteredText = "You entered ";

        private IWebElement _firstAlertButton => Driver.FindElement(By.Id("alertButton"));
        private IWebElement _secondAlertButton => Driver.FindElement(By.Id("confirmButton"));
        private IWebElement _secondAlertResult => Driver.FindElement(By.Id("confirmResult"));
        private IWebElement _thirdAlertButton => Driver.FindElement(By.Id("promtButton"));
        private IWebElement _thirsAlertResult => Driver.FindElement(By.Id("promptResult"));

        public AlertPage(IWebDriver webdriver) : base(webdriver) { }

        public AlertPage NavigateToDefaultPage()
        {

            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }

        public AlertPage ClickFirstAlertButton()
        {
            _firstAlertButton.Click();
            return this;
        }

        public AlertPage AcceptFirstAlert()
        {
            IAlert alert = Driver.SwitchTo().Alert();
            alert.Accept();

            return this;
        }

        public AlertPage ClickSecondAlertButton()
        {
            _secondAlertButton.Click();

            return this;
        }

        public AlertPage CancelSecondAlert()
        {
            Driver.SwitchTo().Alert().Dismiss();

            return this;
        }

        public AlertPage VerifySecondAlertText(string text)
        {
            Assert.AreEqual($"{YouSelectedText}{text}", _secondAlertResult.Text, "Alert result is wrong!");

            return this;
        }

        public AlertPage ClickOnThirdAlertButton()
        {
            _thirdAlertButton.Click();

            return this;
        }

        public AlertPage SendKeysToThirdAlert(string text)
        {
            IAlert alert = Driver.SwitchTo().Alert();
            alert.SendKeys(text);
            alert.Accept();

            return this;
        }

        public AlertPage VerifyThirdAlertText(string text)
        {
            Assert.AreEqual($"{YouEnteredText}{text}", _thirsAlertResult.Text, "Alert result is wrong!");

            return this;
        }
    }
}
}
