using System;
using System.Collections.Generic;
using System.Text;
using eShopOnContainers.Core.ViewModels;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;

namespace eShopOnContainers.Core.ViewModels
{
    public class FiltersViewModel : Popup
    {
        public FiltersViewModel()
        {
            
        }
        protected override object GetLightDismissResult()
        {
            return GetLightDismissResult();
        }
        public void OnFilterClicked(System.Object sender, System.EventArgs e)
        {
            if (BindingContext is CadirViewModel viewModel)
            {
                viewModel.FilterCommand.Execute(null);
                this.Dismiss(true);
            }
        }
    }
}
