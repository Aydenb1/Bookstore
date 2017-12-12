using Foundation;
using System;
using UIKit;

namespace Bookstore
{
    public partial class BookTableViewCell : UITableViewCell
    {
		private Book bookData;

		public Book BookData
		{
            get { return bookData; }
			set {
                bookData = value;

                LabelName.Text = bookData.Name;
                LabelYear.Text = bookData.Year.ToString();
                LabelAuthor.Text = bookData.Author;
                LabelPublisher.Text = bookData.Publisher;
            }
		}

        public BookTableViewCell (IntPtr handle) : base (handle)
        {
            
        }
    }
}