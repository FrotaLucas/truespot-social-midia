﻿using TrueSpot.Views;

namespace TrueSpot
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(CreateEvent), typeof(CreateEvent));
        }
    }
}