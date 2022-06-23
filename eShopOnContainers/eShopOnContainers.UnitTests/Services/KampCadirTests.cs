using eShopOnContainers.Core.Services.KampCadir;
using System.Threading.Tasks;
using eShopOnContainers.Core.ViewModels.Base;
using Xunit;

namespace eShopOnContainers.UnitTests
{
    public class KampCadirTests
    {
        public KampCadirTests()
        {
            ViewModelLocator.UpdateDependencies(true);
        }
        [Fact]
        public async Task KatalogGetirBosMuEvet()
        {
            var CadirMockService = new CadirMockService();
            var cadir = await CadirMockService.GetCatalogAsync();
            Assert.Empty(cadir);
        } //yanlıs olanı test ettik cadirmock servis bos degil doludur o yüzden hata verecektir.
        [Fact]
        public async Task KatalogGetirBosMuHayır()
        {
            var CadirMockService = new CadirMockService();
            var cadir = await CadirMockService.GetCatalogAsync();
            Assert.NotEmpty(cadir);
        } // Dogru test bu olmalıydı ve bunuda deneyip dogrulugunu test ettik.
        [Fact]
        public async Task KatalogTipiVarMı()
        {
            var CadirMockService = new CadirMockService();
            var cadir = await CadirMockService.GetCatalogTypeAsync();
            Assert.NotNull(cadir);
        } // dogru bir test tipleri yazdırmıstık mock servislerinde

    }
}