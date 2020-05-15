using BookstoreXamarin.views;
using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookstoreXamarin.ViewModel
{
    public class BookViewModel : BaseViewModel
    {
        public BookViewModel()
        {
            MainPage mainPage = new MainPage();

            books = mainPage.bookDetails;
        }
        ObservableCollection<BookDetails> books;
        public ObservableCollection<BookDetails> Books
        {
            get { return books; }
            set
            {
                books = value;
                OnPropertyChanged();
            }
        }
        private BookDetails selectedBok;
        public BookDetails SelectedBook
        {
           
            get { return selectedBok; }
            set
            {
                selectedBok = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectionCommand => new Command(DisplayBooks);

        private void DisplayBooks()
        {
            var viewModel = new DetailsViewModel { SelectedBook = selectedBok, Books = books, Position = books.IndexOf(selectedBok) };
            var detailsPage = new Cart { BindingContext = viewModel };
        }
    }
}
