using System;
using OpenQA.Selenium;
using Selenium.core;
using Selenium.core.browsers;

namespace Selenium.pages
{
    public class CreateSchedule
    {
        private readonly IBrowser _browser;

        public CreateSchedule(IBrowser browser)
        {
            _browser = browser;
        }

      

        public CreateSchedule LoginAsAdmin()
        {
            Console.WriteLine("login as admin aspnetzero");
            var elementUsername = _browser.Page.FindElement(By.Name("userNameOrEmailAddress"));
            var elementPassword = _browser.Page.FindElement(By.Name("password"));
            elementUsername.Clear();
            elementPassword.Clear();
            elementUsername.SendKeys("crrmanager");
            elementPassword.SendKeys("123456");
            _browser.Page.FindElement(By.XPath("//button[@type='submit']")).Click();
            return new CreateSchedule(_browser);
        }

        public CreateSchedule GoesToSchedule()
        {
            Console.WriteLine("go to scheduleplanner");
            _browser.Page.FindElement(By.XPath($"//a[@href='/IWMSDEV/app/workorder/scheduleplanner']")).Click();
            return new CreateSchedule(_browser);
        }

        public CreateSchedule GoesToScheduleDetail(string dates)
        {
            Console.WriteLine("go to scheduleplanner detail");
          
            var element = _browser.Page.FindElement(By.XPath($"//td[@data-date='{dates}']"));
            element.FindElement(By.XPath("//span[contains(text(),'22')]")).Click();
            System.Threading.Thread.Sleep(8000);


            _browser.Page.FindElement(By.XPath("//button[contains(text(),'NEW')]")).Click();
            System.Threading.Thread.Sleep(4000);

            var elegigle = _browser.Page.FindElement(By.Name("customer"));
            var eleitem = _browser.Page.FindElement(By.Name("item"));
            var eledcti = _browser.Page.FindElement(By.Name("DCTINo"));
            var elevehicle = _browser.Page.FindElement(By.Name("resource"));
            var eledriver = _browser.Page.FindElement(By.Name("driver"));
            var add = _browser.Page.FindElement(By.XPath("//div[contains(text(),'Add')]"));
            System.Random rng = new System.Random();
            elegigle.Click();
            System.Threading.Thread.Sleep(2000);

            _browser.Page.FindElement(By.XPath("//small[contains(text(),'090852')]")).Click();
            System.Threading.Thread.Sleep(3000);
            elegigle.Click();
            System.Threading.Thread.Sleep(2000);
            elegigle.FindElement(By.XPath("//input[@role='combobox' and @type='text']")).SendKeys("tan chong");
            System.Threading.Thread.Sleep(2000);
            _browser.Page.FindElement(By.XPath("//small[contains(text(),'051723')]")).Click();
            System.Threading.Thread.Sleep(3000);
            eleitem.Click();
            //System.Threading.Thread.Sleep(2000);
            //eleitem.FindElement(By.XPath("//input[@role='combobox' and @type='text' and @autocomplete='a1f10488a1b5']")).SendKeys("SW307");
            System.Threading.Thread.Sleep(2000);
            _browser.Page.FindElement(By.XPath("//small[contains(text(),'WASTE COOLANT')]")).Click();
            System.Threading.Thread.Sleep(2000);
            eledriver.Click();
            System.Threading.Thread.Sleep(2000);
            eledriver.FindElement(By.XPath("//div//small[contains(text(),'172392173982')]")).Click();
            System.Threading.Thread.Sleep(2000);
            eledcti.SendKeys(rng.Next(10000,99999).ToString());
            System.Threading.Thread.Sleep(2000);
            elevehicle.Click();
            System.Threading.Thread.Sleep(2000);
            _browser.Page.FindElement(By.XPath("//span[contains(text(),'BHU8769')]")).Click();
            System.Threading.Thread.Sleep(2000);
            
            add.Click();
            System.Threading.Thread.Sleep(5000);

            return new CreateSchedule(_browser);
        }

      
    }
}