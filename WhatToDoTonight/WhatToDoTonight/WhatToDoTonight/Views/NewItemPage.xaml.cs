using System;
using System.Collections.Generic;
using System.ComponentModel;
using WhatToDoTonight.Models;
using WhatToDoTonight.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatToDoTonight.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}