using DemoQA.Pages;
using NUnit.Framework;
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
            new HomePage(browser).Visit()
                .Should().BeTrue();
            browser.Close();
        }

        [Test]
        [Parallelizable]
        public void UserCanVisitInteractions()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            new InteractionsPage(browser).Visit()
                .Should().BeTrue();
            browser.Close();
        }
        
        [Test]
        [Parallelizable]
        public void UserCanVisitSortable()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            new InteractionsPage(browser).Visit("Sortable")
                .Should().BeTrue();
            browser.Close();
        }
        
        [Test]
        [Parallelizable]
        public void UserCanVisitSelectable()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            new InteractionsPage(browser).Visit("Selectable")
                .Should().BeTrue();
            browser.Close();
        }
        
        [Test]
        [Parallelizable]
        public void UserCanVisitResizable()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            new InteractionsPage(browser).Visit("Resizable")
                .Should().BeTrue();
            browser.Close();
        }
        
        [Test]
        [Parallelizable]
        public void UserCanVisitDroppable()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            new InteractionsPage(browser).Visit("Droppable")
                .Should().BeTrue();
            browser.Close();
        }
        
        [Test]
        [Parallelizable]
        public void UserCanVisitDraggable()
        {
            var browser = new TestBrowser();
            browser.Initialize();
            new InteractionsPage(browser).Visit("Draggable")
                .Should().BeTrue();
            browser.Close();
        }
    }
}
