using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Tests
{
    class AlertTest : TestBase
    {
        [Test]
        public static void TestFirstAlertBox()
        {
            alertPage.NavigateToDefaultPage()
                .ClickFirstAlertButton()
                .AcceptFirstAlert();
        }

        [Test]
        public static void TestSecondAlertBox()
        {
            alertPage.NavigateToDefaultPage()
                .ClickSecondAlertButton()
                .CancelSecondAlert()
                .VerifySecondAlertText("Cancel");
        }

        [TestCase("Alert", TestName = "Third Alert Test")]
        public static void TestThirdAlertBox(string value)
        {
            alertPage.NavigateToDefaultPage()
                .ClickOnThirdAlertButton()
                .SendKeysToThirdAlert(value)
                .VerifyThirdAlertText(value);
        }
    }
}
}
