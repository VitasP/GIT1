using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Tests
{
    class SebCalculatorTest : TestBase
    {
        [Test]
        public static void CalculateLoan()
        {
            sebCalculatorPage.NavigateToDefaultPage()
                .SwitchToFrame()
                .InsertIncome("1000")
                .SelectFromCityDropDownByValue("Klaipeda")
                .ClickCalculateButton()
                .CheckIfICanGetLoan(75000);
        }
    }
}
