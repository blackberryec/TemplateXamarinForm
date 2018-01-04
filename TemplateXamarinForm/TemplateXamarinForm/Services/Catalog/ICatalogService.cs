using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TemplateXamarinForm.Models.Catalog;

namespace TemplateXamarinForm.Services.Catalog
{
    public interface ICatalogService
    {
        Task<ObservableCollection<CatalogBrand>> GetCatalogBrandAsync();
    }
}