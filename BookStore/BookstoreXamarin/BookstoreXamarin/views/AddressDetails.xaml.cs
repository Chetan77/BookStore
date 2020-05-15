using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookstoreXamarin.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddressDetails : ContentPage
    {
        public AddressDetails()
        {
            InitializeComponent();
        }

        private void Continue(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderSummary());
        }
    }
}