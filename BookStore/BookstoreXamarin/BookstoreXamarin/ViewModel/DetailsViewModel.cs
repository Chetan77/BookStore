using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookstoreXamarin.ViewModel
{
    class DetailsViewModel : BaseViewModel
    {
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
        private int position;
        public int Position
        {
            get
            {
                if (position != books.IndexOf(selectedBok))
                    return books.IndexOf(selectedBok);

                return position;
            }
            set
            {
                position = value;
                selectedBok = books[position];

                OnPropertyChanged();
                OnPropertyChanged(nameof(SelectedBook));
            }
        }
        public ICommand ChangePositionCommand => new Command(ChangePosition);

        private void ChangePosition(object obj)
        {
            string direction = (string)obj;

            if (direction == "L")
            {
                if (position == 0)
                {
                    Position = books.Count - 1;
                    return;
                }

                Position -= 1;
            }
            else if (direction == "R")
            {
                if (position == books.Count - 1)
                {
                    Position = 0;
                    return;
                }

                Position += 1;
            }
        }
    }
}
