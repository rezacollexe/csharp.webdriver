using System;
using OpenQA.Selenium;
using Selenium.core.browsers;

namespace Selenium.pages
{
    public class HomePage
    {
        private readonly IBrowser _browser;

        public HomePage(IBrowser browser)
        {
            _browser = browser;
        }

        public RegisterPage Register()
        {
            Console.WriteLine("Navigating to Register page");
            _browser.Page.GoToUrl("http://www.google.com");
            return new RegisterPage(_browser);
        }

        public RegisterPage OpenYahooPage()
        {
            Console.WriteLine("Navigating to Yahoo page");
            _browser.Page.GoToUrl("http://www.yahoo.com");
            return new RegisterPage(_browser);
        }

        public RegisterPage OpenGooglePage()
        {
            Console.WriteLine("Navigating to Google page");
            _browser.Page.GoToUrl("http://www.google.com");
            return new RegisterPage(_browser);
        }

        public RegisterPage OpenGithubPage()
        {
            Console.WriteLine("Navigating to Github page");
            _browser.Page.GoToUrl("http://www.github.com");
            return new RegisterPage(_browser);
        }

        public RegisterPage OpenIwmsPage()
        {
            Console.WriteLine("Navigating to IWMS page");
            _browser.Page.GoToUrl("https://questil.com/iwmsdev");
            
            return new RegisterPage(_browser);
        }

        public RegisterPage OpenEtenderPage()
        {
            Console.WriteLine("Navigating to IWMS page");
            
            _browser.Page.GoToUrl("https://app-plx-staging.azurewebsites.net");
            
            return new RegisterPage(_browser);
        }
    }
}