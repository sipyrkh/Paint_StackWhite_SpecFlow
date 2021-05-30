using Paint.Framework.Element;
using Paint.Framework.Elements;
using System.Windows.Automation;
using TestStack.White.UIItems.Finders;

namespace Paint.App.PageObject.Forms
{
    public class OpenDialogForm
    {
        private TextBox fileNameTxb = new TextBox(SearchCriteria.ByClassName("Edit").AndControlType(ControlType.Edit), "File name");
        private Button openBtn = new Button(SearchCriteria.ByText("Open").AndByClassName("Button"), "Open");

        public void OpenImage(string imagePath)
        {
            InputFileName(imagePath);
            ClickOpen();
        }

        private void InputFileName(string imagePath)
        {
            fileNameTxb.SetValue(imagePath);
        }

        private void ClickOpen()
        {
            openBtn.Click();
        }
    }
}
