using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserEntry.Text) || string.IsNullOrEmpty(PasswordEntry.Text))
            {
                await DisplayAlert("Error", "Debe llenar los campos para loguearse", "ok");
            }
            else
            {
                await DisplayAlert("Aviso", "Bienvenido a la plataforma", "ok");
            }
        }
    }
}
