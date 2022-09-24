using System;
using System.Diagnostics;
using OpenQA.Selenium;
using Selenium.core;
using Selenium.core.browsers;

namespace Selenium.pages
{
    public class CreateRfq
    {
        private readonly IBrowser _browser;

        public CreateRfq(IBrowser browser)
        {
            _browser = browser;
        }

      

        public CreateRfq LoginAsAdmin()
        {
            Console.WriteLine("login as admin aspnetzero");
            var elementUsername = _browser.Page.FindElement(By.Name("userNameOrEmailAddress"),60);
            var elementPassword = _browser.Page.FindElement(By.Name("password"));
            elementUsername.Clear();
            elementPassword.Clear();
            elementUsername.SendKeys("admin@aspnetzero.com");
            elementPassword.SendKeys("123qwe");
            _browser.Page.FindElement(By.XPath("//button[@type='submit']")).Click();
            return new CreateRfq(_browser);
        }

        public CreateRfq GoesToRFXOverView()
        {
            var mainSide = _browser.Page.FindElement(By.TagName("side-bar-menu"));
                var element = mainSide.FindElement(By.Id("kt_aside_menu_wrapper"));
                var elementSecond = element.FindElement(By.Id("kt_aside_menu"));
            var elementThird = elementSecond.FindElement(By.XPath("//ul[@class='kt-menu__nav']/child::li[15]/a"));
            

            elementThird.FindElement(By.XPath("//span[contains(text(),' RFX ')]"));
            _browser.JavaScript.Execute("arguments[0].scrollIntoView(true);", elementThird);
            elementThird.Click();
            System.Threading.Thread.Sleep(6000);

            _browser.Page.FindElement(By.XPath($"//a[@href='/app/event/event-planning']")).Click();
            return new CreateRfq(_browser);
        }

        public CreateRfq GoesToRFXCreate()
        {
            var createRfx = _browser.Page.FindElement(By.XPath("//button[contains(text(),' Create RFX ')]"));
            createRfx.Click();
            System.Threading.Thread.Sleep(5000);

            var secondTimePicker = _browser.Page.FindElement(By.Id("p2"));
            _browser.JavaScript.Execute("arguments[0].scrollIntoView(true);", secondTimePicker);
            
            var elementThird = secondTimePicker.FindElement(By.XPath("//span[@class='e-input-group e-control-wrapper e-datetime-wrapper']/child::span[3]"));
            
            this.SetTimePicker(elementThird,"08:30 PM");
            System.Threading.Thread.Sleep(2000);
            this.SetTimePicker(elementThird, "09:20 PM");
            System.Threading.Thread.Sleep(2000);
            this.SetTimePicker(elementThird, "10:30 PM");
            System.Threading.Thread.Sleep(2000);
            this.SetTimePicker(elementThird, "11:00 PM");

            System.Threading.Thread.Sleep(4000);
            return new CreateRfq(_browser);
        }


        public void SetTimePicker(IWebElement element,string time)
        {
            element.Click();
            System.Threading.Thread.Sleep(3000);
            var timepicker3 = _browser.Page.FindElement(By.Id("p2_timepopup"), 10);
            timepicker3.FindElement(By.XPath($"//li[@data-value='{time}']")).Click();
        }

      
    }
}