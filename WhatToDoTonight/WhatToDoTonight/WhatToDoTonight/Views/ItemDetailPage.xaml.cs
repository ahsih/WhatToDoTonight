using System.ComponentModel;
using WhatToDoTonight.ViewModels;
using Xamarin.Forms;

namespace WhatToDoTonight.Views
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