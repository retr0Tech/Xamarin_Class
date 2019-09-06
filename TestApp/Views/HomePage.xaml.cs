using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }
        private void Listv_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            MessagingCenter.Send<HomePage, string> (this, "STUDENTID", "HELLO");
        }
    }
}
