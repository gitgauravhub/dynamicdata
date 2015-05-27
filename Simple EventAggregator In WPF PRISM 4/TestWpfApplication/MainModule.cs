using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using TestWpfApplication.Views;

namespace TestWpfApplication
{
    internal class MainModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MainModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("FileListRegion", typeof (FileListView));
            _regionManager.RegisterViewWithRegion("FileInfoRegion", typeof (FileInfoView));
        }
    }
}