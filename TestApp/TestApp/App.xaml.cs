﻿using Prism;
using Prism.Ioc;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestApp.ViewModels;
using TestApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TestApp
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            GlobalVariables.ViewLog = new ObservableCollection<string>();

#if PRISM
            // PRISM navigation
            await NavigationService.NavigateAsync("/NavigationPage/MainPage");
#else
            // XF navigation
            MainPage = new NavigationPage(new MainPage());
#endif
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<AnotherPage, AnotherPageViewModel>();
        }
    }
}
