using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium.core;
using Selenium.pages;
using System;

namespace Selenium.tests
{
    [TestFixture]
    [Parallelizable]
    public class IwmsTest : TestBase
    {
        [Test]
        public void TestMethod()
        {
            var day = DateTime.Now.Date.Day;
            var page = new HomePage(Driver);
            page.OpenIwmsPage();
            var login = new CreateSchedule(Driver);
            System.Threading.Thread.Sleep(12000);
            
            login.LoginAsAdmin();
            System.Threading.Thread.Sleep(11000);
            login.GoesToSchedule();
            System.Threading.Thread.Sleep(8000);
            login.GoesToScheduleDetail(DateTime.Now.Date.ToString("yyyy-MM-dd"));
            System.Threading.Thread.Sleep(15000);

        }

    }

   
}