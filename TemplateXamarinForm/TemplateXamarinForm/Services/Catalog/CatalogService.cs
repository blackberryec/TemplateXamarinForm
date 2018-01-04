using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TemplateXamarinForm.Extensions;
using TemplateXamarinForm.Models.Catalog;
using TemplateXamarinForm.Services.RequestProvider;

namespace TemplateXamarinForm.Services.Catalog
{
    public class CatalogService : ICatalogService
    {
        private readonly IRequestProvider _requestProvider;
        public CatalogService(IRequestProvider requestProvider)
        {
            _requestProvider = requestProvider;
        }
        public async Task<ObservableCollection<CatalogBrand>> GetCatalogBrandAsync()
        {
            UriBuilder builder = new UriBuilder("http://13.88.8.119:5101");

            builder.Path = "api/v1/catalog/catalogbrands";

            string uri = builder.ToString();

            IEnumerable<CatalogBrand> brands =
                await _requestProvider.GetAsync<IEnumerable<CatalogBrand>>(uri);

            if (brands != null)
            {
                return brands?.ToObservableCollection();
            }
            else
            {
                return new ObservableCollection<CatalogBrand>();
            }
        }
    }
}