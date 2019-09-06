using System;
using System.Windows.Input;
using TestApp.Models;
using Xamarin.Forms;
using TestApp.Views;
using System.ComponentModel;

namespace TestApp.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        string _result;
        public ICommand clicked { get; set; }
        public User User { get; set; }
        public ICommand tapped { get; set; }
        public string Result
        {
            get;set;
        }
        public UserViewModel() {
            User = new User();
            
            clicked = new Command(async() =>
            {
                if (string.IsNullOrEmpty(User._User) || string.IsNullOrEmpty(User.Password))
                {
                    Result = "Debe llenar todos los campos";
                }
                else
                {
                    await App.Current.MainPage.Navigation.PushAsync(new HomePage());
                }
            });

            tapped = new Command(async() =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
    
}

