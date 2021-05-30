using Paint.Framework.Application;
using Paint.Framework.Logger;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Paint.Framework.Element.Base
{
    public abstract class BaseElement
    {
        protected SearchCriteria elementLocator;
        protected string elementName;

        protected BaseElement(SearchCriteria elementLocator, string elementName)
        {
            this.elementLocator = elementLocator;
            this.elementName = elementName;
        }

        public IUIItem GetElement()
        {
            LoggerUtil.LogInfo($"GetElement: {elementName} - {elementLocator}");
            ApplicationDriver.GetWindow().WaitWhileBusy();
            return ApplicationDriver.GetWindow().Get(elementLocator);
        }

        public void Click()
        {
            LoggerUtil.LogInfo($"Click: {elementName} button - {elementLocator}");
            var button = GetElement();
            button.Click();
        }
    }
}
