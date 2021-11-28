using BookSearch.BL;
using BookSearch.Module.Views;
using BookSearch.Services;
using BookStore.Core;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace BookSearch.Module
{
    public class BookSearchModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public BookSearchModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IBookSearchBL, BookSearchBL>();
           
            containerRegistry.RegisterSingleton<IBookSearchService, BookSearchService>();
        }
    }
}