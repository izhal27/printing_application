using WeifenLuo.WinFormsUI.Docking;

namespace PrintingApplication.Presentation.Helper
{
    public static class DockpanelThemeHelper
    {
        public static ThemeBase GetTheme(int key)
        {
                return new VS2005Theme();

            //if (key == default)
            //{
            //    return new VS2005Theme();
            //}

            //switch (key)
            //{
            //   case 1:
            //      return new VS2012BlueTheme();
            //   case 2:
            //      return new VS2012DarkTheme();
            //   case 3:
            //      return new VS2012LightTheme();
            //   case 4:
            //      return new VS2013BlueTheme();
            //   case 5:
            //      return new VS2013DarkTheme();
            //   case 6:
            //      return new VS2013LightTheme();
            //   case 7:
            //      return new VS2013BlueTheme();
            //   case 8:
            //      return new VS2015DarkTheme();
            //   case 9:
            //      return new VS2015LightTheme();
            //   default:
            //      return new VS2005Theme();
            //}
        }
    }
}
