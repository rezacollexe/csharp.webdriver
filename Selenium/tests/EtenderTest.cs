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
    public class EtenderTest : TestBase
    {
        [Test]
        public void TestMethod()
        {
            var day = DateTime.Now.Date.Day;
            var page = new HomePage(Driver);

            page.OpenEtenderPage();
            var login = new CreateRfq(Driver);
            
            login.LoginAsAdmin();
            login.GoesToRFXOverView();
            login.GoesToRFXCreate();
            

        }

    }

   
}