using System.Linq;
using OpenQA.Selenium;
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
        private el AlertBox => Content.FindId("alert");

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
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            if (!driver.Url.Contains("://demoqa.com"))
                return true;
            return false;
        }

        public bool OpenNewMessageWindow(IWebDriver driver)
        {
            NewMessageWindow.Click();
            if(driver.WindowHandles.Count == 2)
                return true;
            return false;
        }

        public bool OpenNewBrowserTab(IWebDriver driver)
        {
            NewBrowserTab.Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            if (!driver.Url.Contains("://demoqa.com"))
                return true;
            return false;
        }

        public bool OpenAlertBox(IWebDriver driver)
        {
            AlertBox.Click();
            var alertText = driver.SwitchTo().Alert().Text;
            if (alertText.Contains("Knowledge increases by sharing but not by saving. Please share this website with your friends and in your organization."))
                return true;
            return false;
        }
    }
}
