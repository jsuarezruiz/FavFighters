using Xamarin.Forms;
using FavFighters.Views;

namespace FavFighters
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Enable your flags here!
            Device.SetFlags(new[] {
                "SwipeView_Experimental"
            });

            MainPage = new FavFightersView();
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