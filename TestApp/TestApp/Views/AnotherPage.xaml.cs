using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AnotherPage : ContentPage
	{
		public AnotherPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (BindingContext is ViewModels.ViewModelBase)
                ((ViewModels.ViewModelBase)BindingContext).OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnAppearing();

            if (BindingContext is ViewModels.ViewModelBase)
                ((ViewModels.ViewModelBase)BindingContext).OnDisappearing();
        }
    }
}