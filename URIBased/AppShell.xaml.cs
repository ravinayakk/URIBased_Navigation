﻿namespace URIBased
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(HomePage),typeof(HomePage));
            Routing.RegisterRoute(nameof(AnotherPage), typeof(AnotherPage));
        }
    }
}
