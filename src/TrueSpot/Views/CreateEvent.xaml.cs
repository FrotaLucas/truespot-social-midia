using TrueSpot.Models;

namespace TrueSpot.Views;

public partial class CreateEvent : ContentPage
{
    public CreateEvent()
    {
        InitializeComponent();
        BindingContext = new TrueSpotEvent();
    }
}