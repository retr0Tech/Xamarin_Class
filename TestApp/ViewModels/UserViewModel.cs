using System;
using System.Windows.Input;
using TestApp.Models;
using Xamarin.Forms;
using TestApp.Views;

namespace TestApp.ViewModels
{
    public class UserViewModel
    {
        
        public ICommand clicked { get; set; }
        public User User { get; set; }
        public ICommand tapped { get; set; }
        public UserViewModel() {
            User = new User();

            clicked = new Command(async() =>
            {
                if (string.IsNullOrEmpty(User._User) || string.IsNullOrEmpty(User.Password))
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Debe llenar los campos para loguearse", "ok");
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Aviso", $"Bienvenido a la plataforma {User._User}", "ok");
                }
            });

            tapped = new Command(async() =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
            });
        }

        
            

        
    }
    
}

