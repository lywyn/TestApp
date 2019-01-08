using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.Views;
using Xamarin.Forms;

namespace TestApp.ViewModels
{
    public class AnotherPageViewModel : ViewModelBase
    {
#if PRISM
        public AnotherPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Another Page";
            // PRISM navigation
            GoMainPage = new DelegateCommand(() => NavigationService.NavigateAsync("/NavigationPage/MainPage"));
            GoBack = new DelegateCommand(() => NavigationService.GoBackAsync());
        }
#else
        public AnotherPageViewModel()
        {
            Title = "Another Page";
            // XF navigation
            GoMainPage = new DelegateCommand(() => App.Current.MainPage = new NavigationPage(new MainPage()));
            GoBack = new DelegateCommand(() => App.Current.MainPage.Navigation.PopAsync());
        }
#endif

        private DelegateCommand _goBack;
        public DelegateCommand GoBack
        {
            get { return _goBack; }
            set { SetProperty(ref _goBack, value); }
        }

        private DelegateCommand _goMainPage;
        public DelegateCommand GoMainPage
        {
            get { return _goMainPage; }
            set { SetProperty(ref _goMainPage, value); }
        }
    }
}
