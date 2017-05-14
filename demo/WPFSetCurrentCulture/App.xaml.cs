using System.Globalization;
using System.Threading;
using System.Windows;

namespace WPFSetCurrentCulture
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pl-PL");

        }
    }
}
