using DemoQA.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using FluentAssertions;

namespace DemoQA
{
    
    [TestFixture]
    [Parallelizable]
    [Timeout(15000)]
    [Category("Smoke Tests")]
    public class SmokeTests
    {

        [Test]
        [Parallelizable]
        public void UserCanVisitHome()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            var homePage = new HomePage(browser);
            homePage.Visit().Should().BeTrue();
            browser.Close();
        }

        [Test]
        [Parallelizable]
        public void UserCanVisitInteractions()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            var interactionsPage = new InteractionsPage(browser);
            interactionsPage.Visit().Should().BeTrue();
            browser.Close();
        }
        
        [Test]
        [Parallelizable]
        public void UserCanVisitSortable()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            var interactionsPage = new InteractionsPage(browser);
            interactionsPage.Visit("Sortable").Should().BeTrue();
            browser.Close();
        }
        
        [Test]
        [Parallelizable]
        public void UserCanVisitSelectable()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            var interactionsPage = new InteractionsPage(browser);
            interactionsPage.Visit("Selectable").Should().BeTrue();
            browser.Close();
        }
        
        [Test]
        [Parallelizable]
        public void UserCanVisitResizable()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            var interactionsPage = new InteractionsPage(browser);
            interactionsPage.Visit("Resizable").Should().BeTrue();
            browser.Close();
        }
        
        [Test]
        [Parallelizable]
        public void UserCanVisitDroppable()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            var interactionsPage = new InteractionsPage(browser);
            interactionsPage.Visit("Droppable").Should().BeTrue();
            browser.Close();
        }
        
        [Test]
        [Parallelizable]
        public void UserCanVisitDraggable()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            var interactionsPage = new InteractionsPage(browser);
            interactionsPage.Visit("Draggable").Should().BeTrue();
            browser.Close();
        }
    }
}
