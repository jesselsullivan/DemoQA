using DemoQA.Pages;
using NUnit.Framework;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DemoQA.AutomationTests
{
    [TestFixture]
    [Timeout(30000)]
    [Category("Interactions Tests")]
    public class InteractionsTests
    {

        [Test]
        public void UserCanSortItems()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            var interactionsPage = new InteractionsPage(browser);
            interactionsPage.Visit("Sortable");
            var driver = (IWebDriver) browser.Instance.Native;
            Actions act = new Actions(driver);

            var from = 1;
            var to = 2;
            interactionsPage.MoveElementFromTo(from, to, act);
            string[] expected = {"Item 2","Item 1","Item 3","Item 4","Item 5","Item 6","Item 7"};
            var actual = interactionsPage.CheckSort();

            Assert.AreEqual(expected, actual);

            browser.Close();
        }

        [Test]
        [Ignore("Not Implemented Yet")]
        public void UserCanSelectItems()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            var interactionsPage = new InteractionsPage(browser);
            interactionsPage.Visit("Selectable");

            browser.Close();
        }

        [Test]
        [Ignore("Not Implemented Yet")]
        public void UserCanResizeItems()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            var interactionsPage = new InteractionsPage(browser);
            interactionsPage.Visit("Resizable");

            browser.Close();
        }

        [Test]
        [Ignore("Not Implemented Yet")]
        public void UserCanDropItems()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            var interactionsPage = new InteractionsPage(browser);
            interactionsPage.Visit("Droppable");

            browser.Close();
        }

        [Test]
        [Ignore("Not Implemented Yet")]
        public void UserCanDragItems()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            var interactionsPage = new InteractionsPage(browser);
            interactionsPage.Visit("Draggable");

            browser.Close();
        }
    }
}
