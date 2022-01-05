using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VCSautomationProject
{
    public class Class1
    {
        //4 yra lyginis skaicius
        // dabar yra 17 valanda
        [Test]
        public static void TestIf4IsEven()
        {
            int leftOver = 4 % 2;
            Assert.AreEqual(0, leftOver, "4 is not equal");

        }

        [Test]
        public static void TestNowIs17()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(17, currentTime.Hour, "Dabar ne 17val");
        }

        [Test]
        public static void TestIf995IsEven()
        {
            int leftOver = 995 % 3;
            Assert.AreEqual(0, leftOver, "995 dalinasi is 3");
        }

        [Test]
        public static void DayOfWeekWednesday()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(DayOfWeek.Wednesday, currentTime.DayOfWeek, "Dabar yra pirmadienis");
        }

        [Test]
        public static void WaitTo5Seconds()
        {
            Thread.Sleep(50000);
        }
    }
}
