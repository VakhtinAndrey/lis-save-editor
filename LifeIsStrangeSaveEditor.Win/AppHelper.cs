using System.Reflection;

namespace LifeIsStrangeSaveEditor.Win
{
    public static class AppHelper
    {
        public static string GetApplicationVersionShortStr()
        {
            return string.Format("{0}.{1}{2}",
                Assembly.GetExecutingAssembly().GetName().Version.Major,
                Assembly.GetExecutingAssembly().GetName().Version.Minor,
                Assembly.GetExecutingAssembly().GetName().Version.Build != 0
                    ? "." + Assembly.GetExecutingAssembly().GetName().Version.Build
                    : string.Empty);
        }
    }
}
