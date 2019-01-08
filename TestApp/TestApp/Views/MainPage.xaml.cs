using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.ViewModels;
using Xamarin.Forms;

namespace TestApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
#if !PRISM
            BindingContext = new MainPageViewModel();
#endif
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