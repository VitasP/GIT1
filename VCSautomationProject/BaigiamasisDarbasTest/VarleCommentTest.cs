using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSautomationProject.Baigiamasis_darbas
{
    class VarleCommentTest : VarleBaseTest
    {
        [Test]

        public static void CheckIfCommentPosted()
        {
            varleCommentPage.NavigateToDefaultPage()
                .AcceptCookies()
                .ClickReviews()
                .InputComment("geras aptarnavimas")
                .PublishComment()
                .PressBaseComments()
                .VerifyComment("geras aptarnavimas");


        }
    }
}
