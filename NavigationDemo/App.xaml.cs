using NavigationDemo.Common;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationDemo
{
    public partial class App : Application
    {
        private INavigationService _navigationService = ViewNavigationService.Instance;
        public App()
        {
            InitializeComponent();

            _navigationService.Configure("MainPage", typeof(MainPage));
            _navigationService.Configure("Page1", typeof(Page1));
            _navigationService.Configure("Page2", typeof(Page2));

            var mainPage = ((ViewNavigationService)_navigationService).SetRootPage("MainPage");
            MainPage = mainPage;
        }
       
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
