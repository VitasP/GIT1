using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Baigiamasis_darbas
{
    class VarleCartTest : VarleBaseTest
    {
        [Test]
        public static void CheckIfAddedToCart()
        {
            varleCartPage.NavigateToDefaultPage()
                .AcceptCookies()
                .InputSearch("Calvin Klein In2u for Women (Kvepalai Moterims) EDT 150ml")
                .PressSearch()
                .ToProduct()
                .ToBasket()
                .Continue()
                .VerifyCart("1");

        }


    }
}
