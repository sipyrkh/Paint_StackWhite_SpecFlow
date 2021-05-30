using System.Linq;
using Paint.App.Configuration;
using Paint.Framework.Application;
using TechTalk.SpecFlow;
using TestStack.White;
using Paint.Framework.Logger;


namespace Paint.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario(Order = 0)]
        public static void StartApplication()
        {
            foreach (var window in Desktop.Instance.Windows().Where(window => window.Title.Equals(Configuration.WindowName)))
            {
                window.Close();
            }
            LoggerUtil.LogInfo("Application started");
            ApplicationDriver.GetApplication();
        }

        [AfterScenario]
        public static void TearDown()
        {
            LoggerUtil.LogInfo("Application killed");
            ApplicationDriver.KillApplication();
        }
    }
}
