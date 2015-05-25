using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.UnityExtensions;
namespace WPF_PRISM
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            // The shell is comparable to an ASP.NET MasterPage. The shell is usually a UserControl or Page. 
            // Whereas a MasterPage uses ContentPlaceHolder objects, Prism uses Regions (more on that in my next post). 
            // For now, a region is an attached property for specific xaml objects which designates where you can inject your views to display them.
            return this.Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            //Think of ModuleCatalog as a registry of all the modules you plan to load in your application. Once you register them when your application loads
            //they will be loaded in the order you registered them and then each module in turn will inject your views into the main window of your application.
            base.ConfigureModuleCatalog();

            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(Module1.Module1_Initialize));
            moduleCatalog.AddModule(typeof(Module2.Module2_Initialize));
            moduleCatalog.AddModule(typeof(Module3.Module3_Initialize));
        }
    }
}
