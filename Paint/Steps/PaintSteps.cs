using TechTalk.SpecFlow;
using NUnit.Framework;
using Paint.App.PageObject.Forms;
using Paint.Framework.Application;
using Paint.App.Configuration;
using Paint.Framework.Utils;

namespace Paint.Steps
{
    [Binding]
    public class PaintSteps
    {
        private readonly HomeForm homeForm = new HomeForm();
        private readonly OpenDialogForm openDialogForm = new OpenDialogForm();
        private readonly SaveChangesDialogForm saveChangesDialogForm = new SaveChangesDialogForm();

        [Given(@"'Paint' application is started")]
        public void StartApplication()
        {
            Assert.IsTrue(ApplicationDriver.IsApplicationStart(), "Application is not started");
        }

        [When(@"I open image in 'Paint' application")]
        public void OpenImage()
        {
            homeForm.OpenFileTab();
            homeForm.GetFileTab().ClickOpen();
            openDialogForm.OpenImage(Configuration.ImagePath);
        }

        [When(@"I click button 'Select' and choose 'Select All' option on 'Image' section")]
        public void ClickSelectAndChooseSelectAll()
        {
            homeForm.GetImageSection().ClickSelect();
            homeForm.GetImageSection().ClickSelectAll();
        }

        [When(@"I click button 'Cut' on 'Clipboard' section")]
        public void ClickCut()
        {
            homeForm.GetClipboardSection().ClickCut();
          
        }

        [When(@"I close 'Paint' application")]
        public void CloseApplication()
        {
            homeForm.CloseApp();

        }

        [Then(@"Dialog form is displayed")]
        public void CheckStateOfDialogForm()
        {
            Assert.IsTrue(saveChangesDialogForm.IsFormDisplayed(), "Dialog form isn't displayed");
        }

        [Then(@"Image file isn't modified after closing application")]
        public void CheckImageChanges()
        {
            Assert.IsFalse(FileFunctions.FileIsChanged(Configuration.ImagePath), "Image file is modified by autotest");
        }

        [When(@"I click 'Don't Save' button on dialog form")]
        public void DoNotSaveChanges()
        {
            saveChangesDialogForm.DoNotSaveChanges();
        }
    }
}
