namespace TrueSpot.Views
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

        private async void Create_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CreateEvent));
        }
    }
}