using TrueSpot.Models;
using TrueSpot.Workflows;

namespace TrueSpot.Views;

public partial class CreateEvent : ContentPage
{
    private readonly EventWorkflow eventWorkflow;
    private readonly TrueSpotState state;

    public CreateEvent(EventWorkflow eventWorkflow,
                       TrueSpotState state)
    {
        InitializeComponent();

        this.eventWorkflow = eventWorkflow;
        this.state = state;

        StartDate.PropertyChanged += StartDate_PropertyChanged;

        StartDate.MinimumDate = DateTime.Today;
        EndDate.MinimumDate = StartDate.Date;
    }

    private void StartDate_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(StartDate.Date))
            EndDate.MinimumDate = StartDate.Date;
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        var start = StartDate.Date.Add(StartTime.Time);
        var end = EndDate.Date.Add(EndTime.Time);

        var createdEvent = eventWorkflow.CreateEvent(new TrueSpotUser(), EventTitle.Text, EventDescription.Text, start, end);

        state.Events.Add(createdEvent);

        await Shell.Current.GoToAsync(nameof(MainPage));
    }

    private async void DeleteButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MainPage));
    }
}