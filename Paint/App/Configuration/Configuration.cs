using System.Configuration;
using System.IO;
using System.Text;
using Paint.Framework.Utils;
using Newtonsoft.Json.Linq;

namespace Paint.App.Configuration
{
    public static class Configuration
    {
        private static readonly string TestDataPath = ConfigurationManager.AppSettings["PathToTestData"];
        public static readonly string ImagePath = PathFunctions.GetCombinedPath(ConfigurationManager.AppSettings["PathToImage"]);
        public static readonly string ExeFile = ConfigurationManager.AppSettings["ExeFile"];
        private static readonly JObject JsonValues = JObject.Parse(File.ReadAllText(PathFunctions.GetCombinedPath(TestDataPath), Encoding.Default));
        public static readonly string WindowName = (string) JsonValues["WindowName"];
    }
}
