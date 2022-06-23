using eShopOnContainers.Core.ViewModels;
using eShopOnContainers.UnitTests.Mocks;
using eShopOnContainers.Core.Views;
using eShopOnContainers.Core.ViewModels.Base;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace eShopOnContainers.UnitTests.ViewModels
{
    public class VMProductsTests
    {
        public VMProductsTests()
        {
            ViewModelLocator.UpdateDependencies(true);
        }
        [Fact]
        public async Task FireBaseBaglandıMıTrue()
        {
            var products = new VMProducts();
            var pro = products.connectFirebase();
            Assert.True(pro);
        } // Firebase e baglandı mı connection oldu mu diye test ediyoruz true mu olarak.
        [Fact]
        public async Task FireBaseBaglandıMıFalse()
        {
            var products = new VMProducts();
            var pro = products.connectFirebase();
            Assert.False(pro);
        } // Firebase e baglandı mı connection oldu mu diye test ediyoruz false dedik yani bunun yanlıs olması gereklidir.
        [Fact]
        public async Task MesajVarMı()
        {
            var products = new VMProducts();
            var pro = products.lblMessage;
            Assert.NotNull(pro);
        } //Urunleri firebase den eklerken label mesajı boş degilse burası dogrudur ki mesaj geliyor..
        [Fact]
        public async Task MesajYokMu()
        {
            var products = new VMProducts();
            var pro = products.lblMessage;
            Assert.Null(pro);
        }// mesaj gelmiyor olsaydı burası dogru olur  ve bu kısım hata vermezdi ama test amaclı burasını yanlıs yaptık.
         // Mesaj gelmektedir
    }
}