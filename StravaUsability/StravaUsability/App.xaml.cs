using FreshMvvm;
using StravaUsability.PageModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StravaUsability
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var mainPage = FreshPageModelResolver.ResolvePageModel<FeedPageModel>();
            var navigationContainer = new FreshNavigationContainer(mainPage);
            MainPage = navigationContainer;
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
