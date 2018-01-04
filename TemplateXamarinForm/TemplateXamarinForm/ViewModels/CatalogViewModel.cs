using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TemplateXamarinForm.Models.Catalog;
using TemplateXamarinForm.Services.Catalog;
using TemplateXamarinForm.ViewModels.Base;

namespace TemplateXamarinForm.ViewModels
{
    public class CatalogViewModel : ViewModelBase
    {
        private ObservableCollection<CatalogBrand> _brands;
        private ICatalogService _catalogService;

        public CatalogViewModel(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        public ObservableCollection<CatalogBrand> Brands
        {
            get { return _brands; }
            set
            {
                _brands = value;
                RaisePropertyChanged(() => Brands);
            }
        }

        public override async Task InitializeAsync(object navigationData)
        {
            IsBusy = true;

            // Get Catalog, Brands and Types
            Brands = await _catalogService.GetCatalogBrandAsync();

            IsBusy = false;
        }
    }
}
