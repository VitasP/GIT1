using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Tests
{
    class ND_3_Test : TestBase
    {
        [TestCase("Commands", "\r\ncommands", TestName = "Commands")]
        public static void TestOneCheckBox(string firstChoice, string result)
        {

            nD_3_Page.NavigateToDefaultPage()
                .ClickExpandAllButton()
                .DeselectAllCheckBoxes()
                .ClickOnOneCheckBox(firstChoice)
                .VerifyResults(result);
        }

        [TestCase("Desktop", "Downloads", "\r\ndesktop\r\nnotes\r\ncommands\r\ndownloads\r\nwordFile\r\nexcelFile", TestName = "Desktop, Downloads")]
        [TestCase("Notes", "General", "\r\nnotes\r\ngeneral", TestName = "Notes, General")]
        public static void TestCheckBox2(string firstChoice, string secondChoice, string result)
        {
            nD_3_Page.NavigateToDefaultPage()
                .ClickExpandAllButton()
                .DeselectAllCheckBoxes()
                .ClickOnTwoCheckBoxes(firstChoice, secondChoice)
                .VerifyResults(result);

        }
    }
}
