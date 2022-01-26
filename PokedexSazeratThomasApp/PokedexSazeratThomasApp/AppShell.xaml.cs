using PokedexSazeratThomasApp.ViewModels;
using PokedexSazeratThomasApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PokedexSazeratThomasApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
