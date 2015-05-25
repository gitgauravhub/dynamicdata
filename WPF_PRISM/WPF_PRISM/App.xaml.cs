using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_PRISM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //The Bootstrapper is your starting point when developing any application for 
            //Prism (aka Composite Application Library for WPF/Silverlight). The Bootstrapper is basically class representing your App_Startup method. 
            // Once you’ve completed your Bootstrapper you just initialize it and call Run() inside of App_Startup, like this
            base.OnStartup(e);
            Bootstrapper bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
    }
}
