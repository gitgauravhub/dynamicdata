using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    public class Module3_Initialize : IModule
    {
        private readonly IRegionViewRegistry regionViewRegistry;
        public Module3_Initialize(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;
        }

        public void Initialize()
        {
            regionViewRegistry.RegisterViewWithRegion("FirstShellContent", typeof(Views.View3));
            regionViewRegistry.RegisterViewWithRegion("FirstShellContent", typeof(Views.View3_2));
        }

        
    }
}
