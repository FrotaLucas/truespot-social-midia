using TrueSpot.Models;
using TrueSpot.Views;
using TrueSpot.Workflows;

namespace TrueSpot
{
    public partial class MainPage : ContentPage
    {
        private readonly TrueSpotState state;

        public MainPage(TrueSpotState state)
        {
            InitializeComponent();
            this.state = state;

            BindingContext = state;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CreateEvent));
        }
    }
}