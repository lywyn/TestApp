using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace TestApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        public DelegateCommand LoadLog => new DelegateCommand(() =>
            {
                Log = GlobalVariables.ViewLog;
            });

        public DelegateCommand ResetLog => new DelegateCommand(() =>
            {
                GlobalVariables.ViewLog = new ObservableCollection<string>();
                Log = GlobalVariables.ViewLog;
            });

        public DelegateCommand GoAnotherPage => new DelegateCommand(() =>
             {
                 NavigationService.NavigateAsync("AnotherPage");
             });

        private ObservableCollection<string> _log;
        public ObservableCollection<string> Log
        {
            get { return _log; }
            private set { SetProperty(ref _log, value); }
        }
    }
}
