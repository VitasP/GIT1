using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Baigiamasis_darbas
{
    class VarleLoginTest : VarleBaseTest
    {
        [TestCase("testautovp@gmail.com", "autotestas", "Labas, Testautovp@Gmail.Com", TestName = "VarleLogIn")]
        public static void TestVarleLogIn(string first, string second, string result)
        {
            varleLoginPage.NavigateToDefaultPage()
                .ClickLogin()
                .InsertEmail("testautovp@gmail.com")
                .InsertPassword("autotestas")
                .ClickConfirmLogin()
                .VerifyResult("Labas, Testautovp@Gmail.Com");

            
        }
            
            


    }
}
