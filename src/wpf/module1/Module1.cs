using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Wpf.Modules
{
    public class Module1 : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Wpf.Views.ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}