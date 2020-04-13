using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using el = Coypu.ElementScope;

namespace DemoQA.Pages
{
    public class InteractionsPage
    {
        private TestBrowser Browser;
        public el Content => Browser.Instance.FindCss(".demo-frame");

        public InteractionsPage(TestBrowser browser)
        {
            Browser = browser;
        }

        public bool Visit(string page = "")
        {
            switch (page)
            {
                case "Sortable":
                    Browser.Instance.Visit("/sortable");
                    Browser.WaitUntilElementExists("#sortable");
                    return Browser.Instance.Title.Contains("Sortable");
                case "Selectable":
                    Browser.Instance.Visit("/selectable");
                    Browser.WaitUntilElementExists("#selectable");
                    return Browser.Instance.Title.Contains("Selectable");
                case "Resizable":
                    Browser.Instance.Visit("/resizable");
                    Browser.WaitUntilElementExists("#resizable");
                    return Browser.Instance.Title.Contains("Resizable");
                case "Droppable":
                    Browser.Instance.Visit("/droppable");
                    Browser.WaitUntilElementExists("#droppable");
                    return Browser.Instance.Title.Contains("Droppable");
                case "Draggable":
                    Browser.Instance.Visit("/draggable");
                    Browser.WaitUntilElementExists("#draggable");
                    return Browser.Instance.Title.Contains("Draggable");
                default:
                    Browser.Instance.Visit("/category/interactions/");
                    Browser.WaitUntilElementExists("#content");
                    return Browser.Instance.Title.Contains("Interactions");
            }
        }

        //Sortable methods

        private el FindNthSortable(int n)
        {
            return Content.FindXPath("//*[@id=\"sortable\"]/li["+ n + "]");
        }

        public void MoveElementFromTo(int from, int to, Actions act)
        {
            IWebElement oldPosition = (IWebElement) FindNthSortable(from).Native;

            //Hack - each element is 34 pixels high, elements CAN NOT be placed on top of each other on the exact pixel
            to = (to * 34)-15;

            act.DragAndDropToOffset(oldPosition, 0, to).Build().Perform();
        }

        public string[] CheckSort()
        {
            var allListItems = Content.FindAllCss("#sortable > li");
            var order = new string[allListItems.Count()];
            int count = 0;
            foreach (var element in allListItems)
            {
                order[count] = element.Text;
                count++;
            }
            return order;
        }
    }
}
