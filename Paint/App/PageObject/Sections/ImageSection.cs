using Paint.Framework.Element;
using Paint.Framework.Elements;
using TestStack.White.UIItems.Finders;

namespace Paint.App.PageObject.Sections
{
    public class ImageSection
    {
        private ToolBar toolBar = new ToolBar(SearchCriteria.ByText("Select"), "Select");
        private Button selectAllBtn = new Button(SearchCriteria.ByText("Select all"), "Select All");

        public void ClickSelect()
        {
            toolBar.ClickLastElement();
        }

        public void ClickSelectAll()
        {
            selectAllBtn.Click();
        }
    }
}
