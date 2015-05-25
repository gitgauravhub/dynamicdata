using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    public class Module1_Initialize : IModule
    {
        private readonly IRegionViewRegistry regionViewRegistry;

        public Module1_Initialize(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;   
        }


        public void Initialize()
        {
            regionViewRegistry.RegisterViewWithRegion("FirstShellContent", typeof(Views.View1));
        }
    }
}
