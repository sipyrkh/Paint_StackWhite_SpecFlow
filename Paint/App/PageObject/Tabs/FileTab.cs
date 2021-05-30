using Paint.Framework.Element;
using TestStack.White.UIItems.Finders;

namespace Paint.App.PageObject.Tabs
{
    public class FileTab
    {
        private Button openBtn = new Button(SearchCriteria.ByText("Open"), "Open");

        public void ClickOpen()
        {
            openBtn.Click();
        }
    }
}
