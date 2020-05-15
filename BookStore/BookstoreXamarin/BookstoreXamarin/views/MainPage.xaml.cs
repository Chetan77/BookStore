using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using BookstoreXamarin.views;
using Xamarin.Forms.Internals;
using DocumentFormat.OpenXml.Drawing;

namespace BookstoreXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public ObservableCollection<BookDetails> bookDetails = new ObservableCollection<BookDetails>()
        {
            new BookDetails{ImageName="download.jpg",BookName="java",AuthorName="chetan",Price="1300",Discription="magic"},
            new BookDetails{ImageName="download.jpg",BookName="java",AuthorName="chetan",Price="1300",Discription="magic"},
            new BookDetails{ImageName="download.jpg",BookName="c#",AuthorName="chetan",Price="1200.55",Discription="power" },
            new BookDetails{ImageName="download.jpg",BookName="c#",AuthorName="chetan",Price="1200.55",Discription="power" },
            new BookDetails{ImageName="download.jpg",BookName="Angular",AuthorName="chetan",Price="1111.430",Discription="lazy" },
            new BookDetails{ImageName="download.jpg",BookName="xamarin",AuthorName="chetan",Price="2232.49",Discription="looks" }
        };
        string ImageName;
        string biikName;
        string authorName;
        string price;
        public MainPage()       
        {
            
            InitializeComponent();  
            numberOfBooks.Text = bookDetails.Count.ToString();
            bookList.ItemsSource=bookDetails;
            //ImageName= imageName.Te
               /* imageName.Source = item.ImageName;
                bookName.Text = item.BookName;
                authorName.Text = item.AuthorName;
                price.Text = item.Price;*/

            sort.Items.Add("price:low to high");
            sort.Items.Add("price:high to low");
            sort.Items.Add("new arrivals");
            //string name=BookName.Text;

        }



        private void AddedToCart(Object sender, EventArgs eventArgs ,SelectedItemChangedEventArgs e)
        {
            BookDetails book = new BookDetails();
            int count=0;
            int a = e.SelectedItemIndex;
            foreach (var item in bookDetails)
            {
                if (a == count)
                {
                    book.ImageName = item.ImageName;
                    book.AuthorName = item.AuthorName;
                    book.BookName = item.BookName;
                    book.Price = item.Price;
                    Cart cart = new Cart();
                    cart.AddToCart(book);
                    return;
                }
                count++;
            }
            //addToBag.Text = "Added to bag";

            //bookName.Text=
            //string name=BookName.Text
            var button = new Button { Text = "Added to cart"  };
            /*button.WidthRequest = 50;
            var iname= imageName.Source.ToString();
            var prie = price.Text;
            var aname=authorName.Text;
            var bname= bookName.Text;*/
        }
        private void GoToCart(object sender,EventArgs eventArgs)
        {
            
            Navigation.PushAsync(new Cart());
        }

        private void AddToWhishList(object sender, EventArgs e)
        {
            //addTowishList.Text="Added to wish list";
        }

        private void seacuButtonPressed_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyWord = seacuButtonPressed.Text;
            /*var suggetions = bookDetails.Where<BookDetails>(c => c.Contains(keyWord));
            Enumerable.Where<string>(IEnumerable<BookDetails> bookDetails, keyWord);*/
        }
    }
}
