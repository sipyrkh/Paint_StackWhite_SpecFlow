using Paint.Framework.Element.Base;
using Paint.Framework.Logger;
using TestStack.White.UIItems.Finders;

namespace Paint.Framework.Elements
{
    public class TextBox : BaseElement
    {
        public TextBox(SearchCriteria elementLocator, string elementName) : base(elementLocator, elementName) { }

        public void SetValue(string value)
        {
            LoggerUtil.LogInfo($"Set value: {elementName} text box - {elementLocator}");
            var button = GetElement();
            button.SetValue(value);
        }
    }
}
