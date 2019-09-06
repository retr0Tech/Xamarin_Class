using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TestApp.Models;
using TestApp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TestApp.ViewModels
{
    public class AddContactViewModel
    {
        Contact contact { get; set; }
        
        public ICommand saveClicked { get; set; }

        public AddContactViewModel()
        {
            contact = new Contact();
            
            saveClicked = new Command(async () =>
            {
                MessagingCenter.Send<AddContactViewModel, Contact>(this, "STUDENTID", contact);
            });
        }
    }
}
