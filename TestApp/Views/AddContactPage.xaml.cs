using System;
using System.Collections.Generic;
using TestApp.ViewModels;
using Xamarin.Forms;

namespace TestApp.Views 
{
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage()
        {
            InitializeComponent();
            BindingContext = new AddContactViewModel();
        }
    }
}
