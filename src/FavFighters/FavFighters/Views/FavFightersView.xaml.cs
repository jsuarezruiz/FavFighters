using FavFighters.Models;
using FavFighters.ViewModels;
using Xamarin.Forms;

namespace FavFighters.Views
{
    public partial class FavFightersView : ContentPage
    {
        public FavFightersView()
        {
            InitializeComponent();
            BindingContext = new FavFightersViewModel();

            MessagingCenter.Subscribe<Fighter>(this, "Favorited", (f) =>
            {
                DisplayAlert("Added favorite", $"{f.Name} is added to your favorites!", "Thanks");
            });
        }

        // Uncomment this for the event way
        //void SwipeItemView_Invoked(System.Object sender, System.EventArgs e)
        //{
        //    DisplayAlert("Added favorite", "This fighter is added to your favorites!", "Thanks");
        //}
    }
}