using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.ViewModels
{
    public class AnotherPageViewModel : ViewModelBase
    {
        public AnotherPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Another Page";
            GoMainPage = new DelegateCommand(() => NavigationService.NavigateAsync("myapp:///NavigationPage/MainPage"));
            GoBack = new DelegateCommand(() => NavigationService.GoBackAsync());
        }

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
