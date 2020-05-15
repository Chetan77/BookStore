using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookstoreXamarin.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cart : ContentPage
    {
        ObservableCollection<BookDetails> cartBooks = new ObservableCollection<BookDetails>();
        public Cart()
        {

            InitializeComponent();
            int numberOfBooks = 1;
            value.Text = numberOfBooks.ToString();
        }
        public void AddToCart(BookDetails bookDetails)
        {
            cartBooks.Add(bookDetails);
        }
        private void PlaceOrder(object sender, EventArgs e)
        {
            Navigation.PushAsync( new AddressDetails());
        }

        private void ValueDecrese(object sender, EventArgs e)
        {
            int numberOfBooks = (int)Convert.ToInt32(value);
            numberOfBooks = numberOfBooks - 1;
            value.Text = numberOfBooks.ToString();
        }

        private void ValueIncrese(object sender, EventArgs e)
        {
            int numberOfBooks = (int)Convert.ToInt32(value);
            numberOfBooks = numberOfBooks + 1;
            value.Text = numberOfBooks.ToString();
        }
    }
}