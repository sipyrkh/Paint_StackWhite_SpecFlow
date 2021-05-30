using Paint.Framework.Element.Base;
using Paint.Framework.Logger;
using TestStack.White.UIItems.Finders;
using Paint.Framework.Utils;


namespace Paint.Framework.Element
{
    public class Label : BaseElement
    {
        public Label(SearchCriteria elementLocator, string elementName) : base(elementLocator, elementName) {}

        public string GetText()
        {
            LoggerUtil.LogInfo($"GetText: {elementName} - {elementLocator}");
            var label = (TestStack.White.UIItems.Label) GetElement();
            return label.Text;
        }
    }
}
