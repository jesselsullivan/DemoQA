using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using el = Coypu.ElementScope;

namespace DemoQA.Pages.WidgetPages
{
    public class AutomationPracticeSwitchWindowsPage
    {
        private TestBrowser Browser;

        public el Content => Browser.Instance.FindId("content");
        private el NewBrowserWindow => Content.FindId("button1");
        private el NewMessageWindow => Content.FindXPath("//button[contains(text(),\'New Message Window\')]");
        private el NewBrowserTab => Content.FindXPath("//button[contains(text(),\'New Browser Tab\')]");
        private el NewDemoqaWindow => Content.FindId("buttondemoqa");

        public AutomationPracticeSwitchWindowsPage(TestBrowser browser)
        {
            Browser = browser;
        }

        public bool Visit()
        {
            Browser.Instance.Visit("/automation-practice-switch-windows-2");
            Browser.WaitUntilElementExists("#Deattach");
            return Browser.Instance.Title == "Automation Practice Switch Windows – ToolsQA – Demo Website to Practice Automation";
        }

        public bool OpenNewBrowserWindow(IWebDriver driver)
        {
            NewBrowserWindow.Click();
            List<string> handles = driver.WindowHandles.ToList<string>();
            driver.SwitchTo().Window(handles.Last());
            if (driver.Url == "http://toolsqa.com/")
                return true;
            return false;
        }
    }
}
