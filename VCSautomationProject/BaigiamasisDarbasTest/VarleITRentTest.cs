using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Baigiamasis_darbas
{
    class VarleITRentTest : VarleBaseTest
    {
        [Test]
        public static void VerifyEmail()
        {
            varleITRentPage.NavigateToDefaultPage()
                .AcceptCookies()
                .PressITRent()
                .PressPCInfo()
                .VerifyResult("tomas.kaskonas@varle.lt");
        }
    }
}
