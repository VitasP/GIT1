using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Tests
{
    class DemoqaSelectMenuTest : TestBase
    {
        [Test]
        public static void TestSelectByValue()
        {
            demoqaSelectMenuPage.NavigateToDefaultPage()
                .SelectFromDropDownByValue("5")
                .VerifySingleSelectResult("Black");
        }

        [Test]
        public static void TestSelectByText()
        {
            demoqaSelectMenuPage.NavigateToDefaultPage()
                .SelectFromDropdownByText("Indigo")
                .VerifySingleSelectResult("Indigo");
        }

        [TestCase("Volvo", "Audi")]
        public static void TestMultiSelect(params string[] elements)
        {
            demoqaSelectMenuPage.NavigateToDefaultPage()
                .SelectMultiDropDown(elements.ToList())
                .VerifyMultiSelectDropDown("Volvo Audi");
        }



    }
}
