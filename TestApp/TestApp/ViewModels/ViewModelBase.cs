using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.ViewModels
{
    public class ViewModelBase : BindableBase
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

#if PRISM
        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
#else
        public ViewModelBase() { }
#endif

        public void OnAppearing()
        {
            GlobalVariables.ViewLog.Add($"\n{Title} appearing");
        }

        public void OnDisappearing()
        {
            GlobalVariables.ViewLog.Add($"\n{Title} disappearing");
        }
    }
}
