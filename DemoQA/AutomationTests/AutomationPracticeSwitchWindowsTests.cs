using DemoQA.Pages.WidgetPages;
using NUnit.Framework;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DemoQA.AutomationTests
{
    [TestFixture]
    [Timeout(30000)]
    [Category("Automation Practice Switch Windows Tests")]
    public class AutomationPracticeSwitchWindowsTests
    {
        [Test]
        public void UserCanOpenNewBrowserWindow()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            var automationPracticeSwitchWindowsPage = new AutomationPracticeSwitchWindowsPage(browser);
            automationPracticeSwitchWindowsPage.Visit();
            var driver = (IWebDriver) browser.Instance.Native;

            automationPracticeSwitchWindowsPage.OpenNewBrowserWindow(driver)
                .Should().BeTrue();

            browser.Close();
        }
    }
}
