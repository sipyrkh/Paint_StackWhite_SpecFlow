using Paint.Framework.Element.Base;
using TestStack.White.UIItems.Finders;


namespace Paint.Framework.Element
{
    public class Button : BaseElement
    {
        public Button(SearchCriteria elementLocator, string elementName) : base(elementLocator, elementName) {}

        public string GetName()
        {
            return elementName + " button";
        }
    }
}
