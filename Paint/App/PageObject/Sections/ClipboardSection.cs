using Paint.Framework.Element;
using TestStack.White.UIItems.Finders;

namespace Paint.App.PageObject.Sections
{
    public class ClipboardSection
    {
        private Button cutBtn = new Button(SearchCriteria.ByText("Cut"), "Cut");

        public void ClickCut()
        {
            cutBtn.Click();
        }
    }
}
