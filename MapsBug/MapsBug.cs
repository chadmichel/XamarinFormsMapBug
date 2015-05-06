using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapsBug
{
    public class App : Application
    {
        public App()
        {
            var map = new Map()
            {
                IsShowingUser = true,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand
            };                        

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    Children =
                    {
                        map
                    }
                }
            };

            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(40.811729, -96.694107), Distance.FromMiles(0.3)));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

