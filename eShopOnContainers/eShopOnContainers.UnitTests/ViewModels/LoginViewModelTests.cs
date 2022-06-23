using eShopOnContainers.Core.Models.Catalog;
using eShopOnContainers.Core.Services.Catalog;
using eShopOnContainers.Core.Services.Settings;
using eShopOnContainers.Core.ViewModels;
using eShopOnContainers.Core.ViewModels.Base;
using eShopOnContainers.UnitTests.Mocks;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace eShopOnContainers.UnitTests
{
    public class LoginViewModelTests
    {
        public LoginViewModelTests()
        {
            ViewModelLocator.UpdateDependencies(true);
        }
        [Fact]
        public void GirisUrlNullMuDegilMi()
        {
            var loginviewmodel = new LoginViewModel();
            Assert.Null(loginviewmodel.LoginUrl);
        }
        [Fact]
        public void GirisIslemiDogrumu()
        {
            var loginviewmodel = new LoginViewModel();
            Assert.True(loginviewmodel.IsLogin);
        } //yanlıs yani false deger cıkacak olan test.
        [Fact]
        public void KayitIslemiNullDegilse()
        {
            var loginviewmodel = new LoginViewModel();
            Assert.NotNull(loginviewmodel.RegisterCommand);
        }
    }
}