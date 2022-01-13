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
                .InputSearch("Apple iPhone 13 Pro 128GB Grafito (Graphite)")
                .PressSearch()
                .ToBasket()
                .Continue()
                .VerifyCart("1");

        }


    }
}
