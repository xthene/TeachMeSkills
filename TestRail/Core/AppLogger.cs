namespace TestRail.Core
{
    internal class AppLogger
    {
        private static AppLogger instance;

        private AppLogger()
        {
        }

        public static AppLogger GetInstance()
        {
            return instance ?? (instance = new AppLogger());
        }
    }
}
