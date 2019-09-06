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
    public class HomeViewModel
    {
        Contact _contact;
        public Contact SelectedContact {
            get
            {
                return _contact;
            }
            set
            {
                if (_contact != null)
                    OnSelectedItem(_contact);
            }
        }
        public ICommand DeleteElementCommand { get; set; }
        public ICommand addClicked { get; set; }
        public ICommand SeeElementCommand { get; set; }

        public ObservableCollection<Contact> contact { get; set; }

        public HomeViewModel()
        {
            contact = new ObservableCollection<Contact>();

            contact.Add(new Contact
            {
                FirstName = "Charlin Agramonte",
                Number = "8095555555"
            });

            DeleteElementCommand = new Command<Contact>(async (param) =>
            {
                contact.Remove(param);
            });

            SeeElementCommand = new Command<Contact>(async (param) =>
            {
                var response = await App.Current.MainPage.DisplayActionSheet("Actions", "cancel", "", $"Call +{param.Number}", "Edit");
                if (response == "Edit")
                {
                    await App.Current.MainPage.Navigation.PushAsync(new AddContactPage());
                }
                else
                {
                    Device.OpenUri(new Uri(String.Format($"tel:{param.Number}")));
                }
            });

            addClicked = new Command(async() =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new AddContactPage());
            });

            MessagingCenter.Subscribe<HomePage, string>(this, "STUDENTID", ((sender, param) =>
            {
                MessagingCenter.Unsubscribe<HomePage, string>(this, "TESTID");
            }));

            MessagingCenter.Subscribe<AddContactViewModel, Contact>(this, "STUDENTID", ((sender, param) =>
            {
                contact.Add(param);
                MessagingCenter.Unsubscribe<AddContactViewModel, Contact>(this, "TESTID");
            }));
        }
        void OnSelectedItem(Contact thisContact)
        {
            Contact myContact = new Contact();
            myContact.FirstName = "New Contact";
            myContact.Number = "8097777777";

            contact.Add(myContact);
        }
    }
}
