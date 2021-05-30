using Paint.Framework.Element.Base;
using System.Windows;
using System.Windows.Automation;
using TestStack.White.InputDevices;
using TestStack.White.UIItems.Finders;

namespace Paint.Framework.Elements
{
    public class ToolBar : BaseElement
    {
        public ToolBar(SearchCriteria elementLocator, string elementName) : base(elementLocator, elementName) { }

        public void ClickLastElement()
        {
            var toolbar = GetElement();
            AutomationElement element = toolbar.AutomationElement;
            var listElements = element.FindAll(TreeScope.Children, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.SplitButton));
            var clickablePoint = new Point();
            foreach (AutomationElement el in listElements)
            {
                if (el.Current.Name.Equals(elementName))
                {
                    clickablePoint = el.GetClickablePoint();
                }
            }
            Mouse.Instance.Click(clickablePoint);
        }
    }
}
