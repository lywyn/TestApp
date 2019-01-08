using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TestApp.Views;

namespace TestApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
#if PRISM
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Main Page";
            // PRISM navigation
            GoAnotherPage = new DelegateCommand(() => NavigationService.NavigateAsync("AnotherPage"));
        }
#else
        public MainPageViewModel()
        {
            Title = "Main Page";
            // XF navigation
            GoAnotherPage = new DelegateCommand(() => App.Current.MainPage.Navigation.PushAsync(new AnotherPage()));
        }
#endif

        public DelegateCommand LoadLog => new DelegateCommand(() =>
            {
                Log = GlobalVariables.ViewLog;
            });

        public DelegateCommand ResetLog => new DelegateCommand(() =>
        {
            GlobalVariables.ViewLog = new ObservableCollection<string>();
            Log = GlobalVariables.ViewLog;
        });

        private DelegateCommand _goAnotherPage;
        public DelegateCommand GoAnotherPage
        {
            get { return _goAnotherPage; }
            set { SetProperty(ref _goAnotherPage, value); }
        }

        private ObservableCollection<string> _log;
        public ObservableCollection<string> Log
        {
            get { return _log; }
            private set { SetProperty(ref _log, value); }
        }
    }
}
