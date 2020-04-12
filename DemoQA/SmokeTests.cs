using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using FluentAssertions;

namespace DemoQA
{
    
    [TestClass]
    [TestCategory("Smoke Tests")]
    public class SmokeTests
    {
        [TestMethod]
        public void UserCanVisitHome()
        {
            string targetUrl = "https://demoqa.com/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(targetUrl);
            var resultUrl = driver.Url;
            resultUrl.Should().BeEquivalentTo(targetUrl);
            driver.Close();
        }

        [TestMethod]
        public void UserCanVisitInteractions()
        {
            string targetUrl = "https://demoqa.com/category/interactions/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(targetUrl);
            var resultUrl = driver.Url;
            resultUrl.Should().BeEquivalentTo(targetUrl);
            driver.Close();
        }
    }
}
