﻿using PokedexSazeratThomasApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PokedexSazeratThomasApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}