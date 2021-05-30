using Paint.App.Configuration;

namespace Paint.Framework.Application
{
    public static class AppFactory
    {
        private static TestStack.White.Application application;

        public static TestStack.White.Application GetInstance()
        {
            return application ?? (application = TestStack.White.Application.Launch(Configuration.ExeFile));
        }
    }
}
