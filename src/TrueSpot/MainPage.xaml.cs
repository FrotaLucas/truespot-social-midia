using TrueSpot.Models;
using TrueSpot.Workflows;

namespace TrueSpot
{
    public partial class MainPage : ContentPage
    {
        private readonly EventWorkflow eventWorkflow;
        private int count = 0;
        private List<TrueSpotEvent> events = new List<TrueSpotEvent>();

        public MainPage(EventWorkflow eventWorkflow)
        {
            InitializeComponent();
            this.eventWorkflow = eventWorkflow;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}