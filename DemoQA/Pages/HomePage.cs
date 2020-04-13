namespace DemoQA.Pages
{
    internal class HomePage
    {
        private TestBrowser Browser;

        public HomePage(TestBrowser browser)
        {
            Browser = browser;
        }

        public bool Visit()
        {
            Browser.Instance.Visit("/");
            Browser.WaitUntilElementExists("#content");
            return Browser.Instance.Title == "ToolsQA – Demo Website to Practice Automation – Demo Website to Practice Automation";
        }
    }
}