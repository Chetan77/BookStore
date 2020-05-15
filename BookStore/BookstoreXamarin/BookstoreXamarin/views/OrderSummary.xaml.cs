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
    public partial class OrderSummary : ContentPage
    {
        public OrderSummary()
        {
            InitializeComponent();
        }

        private void successPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderSuccessPage());
        }
    }
}