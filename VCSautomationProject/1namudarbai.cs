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
    class ND1
    {
        private static IWebDriver _driver;
        [Test]
        public static void TestNumericalPluses()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";
            IWebElement firstNumber = driver.FindElement(By.Id("number1"));
            firstNumber.SendKeys("2");
            IWebElement secondNumber = driver.FindElement(By.Id("number2"));
            secondNumber.SendKeys("2");
            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();
            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.AreEqual("4", result.Text, "Wrong");
            driver.Close();
        }

        [Test]
        public static void TestNegativeNumericalPluses()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";
            IWebElement firstNumber = driver.FindElement(By.Id("number1"));
            firstNumber.SendKeys("-5");
            IWebElement secondNumber = driver.FindElement(By.Id("number2"));
            secondNumber.SendKeys("3");
            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();
            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.AreEqual("-2", result.Text, "Wrong");
            driver.Close();
        }

        [Test]
        public static void TestLetterPluses()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";
            IWebElement firstNumber = driver.FindElement(By.Id("number1"));
            firstNumber.SendKeys("a");
            IWebElement secondNumber = driver.FindElement(By.Id("number2"));
            secondNumber.SendKeys("b");
            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();
            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.AreEqual("ab", result.Text, "Wrong");
            driver.Close();
        }

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://testpages.herokuapp.com/styled/calculator";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Close();
        }


        [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
        public static void TestSumBlock(string firstInputvalue, string secondInputValue, string expectedResult)
        {
            IWebElement firstInput = _driver.FindElement(By.Id("number1"));
            IWebElement secondInput = _driver.FindElement(By.Id("number2"));

            firstInput.Clear();
            firstInput.SendKeys(firstInputvalue);
            secondInput.Clear();
            secondInput.SendKeys(secondInputValue);

            IWebElement calculateButton = _driver.FindElement(By.Id("calculate"));
            calculateButton.Click();

            IWebElement actualResult = _driver.FindElement(By.Id("answer"));
            Assert.AreEqual(expectedResult, actualResult.Text, "Sum is Incorrect");
        }


    }
}
