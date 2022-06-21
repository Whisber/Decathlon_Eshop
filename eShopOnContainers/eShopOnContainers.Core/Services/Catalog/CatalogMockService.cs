using eShopOnContainers.Core.Extensions;
using eShopOnContainers.Core.Models.Catalog;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eShopOnContainers.Core.Services.Catalog
{
    public class CatalogMockService : ICatalogService
    {
        private ObservableCollection<CatalogBrand> MockCatalogBrand = new ObservableCollection<CatalogBrand>
        {
            new CatalogBrand { Id = 1, Brand = "Salcano" },
            new CatalogBrand { Id = 2, Brand = "Quecho" },
            new CatalogBrand { Id = 3, Brand = "Umit bisiklet" }
        };

        private ObservableCollection<CatalogType> MockCatalogType = new ObservableCollection<CatalogType>
        {
            new CatalogType { Id = 1, Type = "Bisiklet" },
            new CatalogType { Id = 2, Type = "Cadir" }
        };

        private ObservableCollection<CatalogItem> MockCatalog = new ObservableCollection<CatalogItem>
        {
            new CatalogItem { Id = Common.Common.MockCatalogItemId01, PictureUri = "KampCadir1.png", Name = "Cadir1(S)", Price = 30.00M, CatalogBrandId = 2, CatalogBrand = "Decathlon", CatalogTypeId = 2, CatalogType = "Cadir" },
            new CatalogItem { Id = Common.Common.MockCatalogItemId02, PictureUri = "KampCadir2.png", Name = "Cadir2(M)", Price = 45.00M, CatalogBrandId = 2, CatalogBrand = "Decathlon", CatalogTypeId = 2, CatalogType = "Cadir" },
            new CatalogItem { Id = Common.Common.MockCatalogItemId03, PictureUri = "KampCadir3.png", Name = "Cadir3(L)", Price = 70.00M, CatalogBrandId = 2, CatalogBrand = "Decathlon", CatalogTypeId = 2, CatalogType = "Cadir" },
            new CatalogItem { Id = Common.Common.MockCatalogItemId04, PictureUri = "BisikletEkle1.jpg", Name = "21 Vites bisiklet", Price = 180.00M, CatalogBrandId = 1, CatalogBrand = "Salcano", CatalogTypeId = 1, CatalogType = "Bisiklet" },
            new CatalogItem { Id = Common.Common.MockCatalogItemId05, PictureUri = "BisikletEkle2.jpg", Name = "18 Vites bisiklet", Price = 160.50M, CatalogBrandId = 3, CatalogBrand = "Umit bisiklet", CatalogTypeId = 1, CatalogType = "Bisiklet" }
        };

        public async Task<ObservableCollection<CatalogItem>> GetCatalogAsync()
        {
            await Task.Delay(10);

            return MockCatalog;
        }

        public async Task<ObservableCollection<CatalogItem>> FilterAsync(int catalogBrandId, int catalogTypeId)
        {
            await Task.Delay(10);

            return MockCatalog
                .Where(c => c.CatalogBrandId == catalogBrandId &&
                c.CatalogTypeId == catalogTypeId)
                .ToObservableCollection();
        }

        public async Task<ObservableCollection<CatalogBrand>> GetCatalogBrandAsync()
        {
            await Task.Delay(10);

            return MockCatalogBrand;
        }

        public async Task<ObservableCollection<CatalogType>> GetCatalogTypeAsync()
        {
            await Task.Delay(10);

            return MockCatalogType;
        }
    }
}