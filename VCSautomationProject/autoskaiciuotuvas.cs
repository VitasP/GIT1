using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject
{
    class autoskaiciuotuvas
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://testsheepnz.github.io/BasicCalculator.html#main-body";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Close();
        }

        [TestCase("25", "25.5", false, "50.5", TestName ="25 + 25,5= 50,5")]
        [TestCase("5", "25.5", true, "30", TestName = "5 + 25,5= 30")]
        [TestCase("1.99", "0.959", false, "2.949", TestName = "1,99 + 0,959= 2,949")]
        [TestCase("-1", "-9.99", true, "-10", TestName = "-1 + -9= -10")]

        public static void TestSumBlock(string firstInputValue, string secondInputValue, bool shouldBeChecked, string result)
        {
            IWebElement firstinput = _driver.FindElement(By.Id("number1Field"));
            IWebElement secondinput = _driver.FindElement(By.Id("number2Field"));

            firstinput.Clear();
            firstinput.SendKeys(firstInputValue);
            secondinput.Clear();
            secondinput.SendKeys(secondInputValue);

            IWebElement intOnlyCheckBox = _driver.FindElement(By.Id("integerSelect"));
            if (shouldBeChecked)
            {
                intOnlyCheckBox.Click();
            }

            IWebElement calculate = _driver.FindElement(By.Id("calculateButton"));
            calculate.Click();

            IWebElement actualResult = _driver.FindElement(By.Id("numberAnswerField"));
            Assert.AreEqual(result, actualResult.GetAttribute("value"), "Sum is Incorrect");

        }
    }
}
