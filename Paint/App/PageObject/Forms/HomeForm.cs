using Paint.App.PageObject.Sections;
using Paint.App.PageObject.Tabs;
using Paint.Framework.Element;
using TestStack.White.UIItems.Finders;

namespace Paint.App.PageObject.Forms
{
    public class HomeForm
    {
        private Button fileBtn = new Button(SearchCriteria.ByText("File tab"), "File");
        private Button closeBtn = new Button(SearchCriteria.ByAutomationId("Close"), "Close");

        public void OpenFileTab()
        {
            fileBtn.Click();
        }

        public void CloseApp()
        {
            closeBtn.Click();
        }

        public FileTab GetFileTab()
        {
            return new FileTab();
        }

        public ImageSection GetImageSection()
        {
            return new ImageSection();
        }

        public ClipboardSection GetClipboardSection()
        {
            return new ClipboardSection();
        }
    }
}
