using System;
using System.Windows.Input;
using TestApp.Models;
using Xamarin.Forms;
using TestApp.Views;

namespace TestApp.ViewModels
{
    public class RegisterViewModel
    {
        public User User { get; set; }
        public ICommand clicked { get; set; }
        public RegisterViewModel()
        {
            User = new User();

            clicked = new Command(async () =>
            {
                if (string.IsNullOrEmpty(User._User) || string.IsNullOrEmpty(User.Password))
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Debe llenar los campos para loguearse", "ok");
                }
                else
                {
                    await App.Current.MainPage.Navigation.PushAsync(new HomePage());
                }
            });

        }
    }
}
