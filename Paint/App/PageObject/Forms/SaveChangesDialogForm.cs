using Paint.Framework.Element;
using TestStack.White.UIItems.Finders;

namespace Paint.App.PageObject.Forms
{
    public class SaveChangesDialogForm
    {
        private Button doNotSaveBtn = new Button(SearchCriteria.ByAutomationId("CommandButton_7"), "Don't Save");

        public void DoNotSaveChanges()
        {
            doNotSaveBtn.Click();
        }

        public bool IsFormDisplayed()
        {
            return doNotSaveBtn.GetElement().Visible;
        }
    }
}
