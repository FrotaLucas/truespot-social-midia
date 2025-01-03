using TrueSpot.Models;
using TrueSpot.Views;
using TrueSpot.Workflows;

namespace TrueSpot
{
    public partial class MainPage : ContentPage
    {
        private readonly EventWorkflow eventWorkflow;
        private List<TrueSpotEvent> events = new List<TrueSpotEvent>();

        public MainPage(EventWorkflow eventWorkflow)
        {
            InitializeComponent();
            this.eventWorkflow = eventWorkflow;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CreateEvent));
        }
    }
}