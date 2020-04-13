using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Pages
{
    internal class InteractionsPage
    {
        private TestBrowser Browser;

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
    }
}
