using System.Windows;

namespace TestWpfApplication
{
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            (new Bootstrapper()).Run();
        }
    }
}