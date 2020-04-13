using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using FluentAssertions;

namespace DemoQA
{
    [TestFixture]
    public class InteractionsTests
    {
        [Test]
        public void UserCanSortItems()
        {
            string targetUrl = "https://demoqa.com/sortable/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(targetUrl);


        }

        [Test]
        public void UserCanSelectItems()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void UserCanResizeItems()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void UserCanDropItems()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void UserCanDragItems()
        {
            throw new NotImplementedException();
        }
    }
}
