using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Baigiamasis_darbas
{
    class VarleHelpTest : VarleBaseTest
    {
        [Test]

        public static void VerifyCodeandEmail()
        {
            varleHelpPage.NavigateToDefaultPage()
                .AcceptCookies()
                .PressOnMessage()
                .NavigateToHelp()
                .NavigateToCompany()
                .VerifyCodeandEmail("302431995", "info@varle.lt");
        }

    }
}
