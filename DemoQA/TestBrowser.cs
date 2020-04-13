using System;
using System.Configuration;
using System.Threading;
using Coypu;
using Coypu.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoQA
{
    public class TestBrowser
    {
        public BrowserSession Instance { get; set; }
        private IWebDriver Native => (IWebDriver) Instance.Native;

        public readonly string AppHost = ConfigurationManager.AppSettings["AppHost"];
        public readonly int Port = int.Parse(ConfigurationManager.AppSettings["AppPort"] ?? "80");
        public readonly string BrowserChoice = ConfigurationManager.AppSettings["Browser"];

        public void Initialize()
        {
            var sessionConfiguration = new SessionConfiguration
            {
                AppHost = AppHost,
                SSL = AppHost.Contains("https"),
                Port = Port,
                Browser = GetBrowser(BrowserChoice),
            };
            
            Instance = new BrowserSession(sessionConfiguration);
        }

        public void WaitUntilElementExists(string elementSelector, int timeout = 20)
        {
            try
            {
                var wait = new WebDriverWait(Native, TimeSpan.FromSeconds(timeout));
                wait.Until(ExpectedConditions.ElementExists(By.CssSelector(elementSelector)));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementSelector +
                                  "' was not found in current context page after "
                                  + timeout + " seconds.");
                throw;
            }
        }

        public void Close()
        {
            Instance?.Dispose();
        }

        public void WaitSeconds(int seconds)
        {
            Thread.Sleep((int) TimeSpan.FromSeconds(seconds).TotalSeconds * 1000);
        }

        public void Refresh()
        {
            Instance.Refresh();
        }

        private Browser GetBrowser(string choice)
        {
            switch (choice)
            {
                case "Internet Explorer":
                    return Browser.InternetExplorer;
                case "Firefox":
                    return Browser.Firefox;
            }

            return Browser.Chrome;
        }
    }
}