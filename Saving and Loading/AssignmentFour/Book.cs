using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentFour
{
    public class Book
    {
        private string title, author, genre, releaseDate, supplierInfo;
        private long isbn;
        private float price;

        public Book()
        {
        }

        public Book(string _bookTitle, string _bookAuthor, string _bookGenre, string _bookReleaseDate, string _supplierInfo, long _bookISBN, float _bookPrice)
        {
            title = _bookTitle;
            author = _bookAuthor;
            genre = _bookGenre;
            releaseDate = _bookReleaseDate;
            supplierInfo = _supplierInfo;
            isbn = _bookISBN;
            price = _bookPrice;
        }


        public string getTitle()
        {
            return title;
        }

        public void setTitle(string tempTitle)
        {
            title = tempTitle;
        }

        public string getAuthor()
        {
            return author;
        }

        public void setAuthor(string tempAuthor)
        {
            author = tempAuthor;
        }

        public string getGenre()
        {
            return genre;
        }

        public void setGenre(string tempGenre)
        {
            genre = tempGenre;
        }

        public string getReleaseDate()
        {
            return releaseDate;
        }

        public void setReleaseDate(string tempReleaseDate)
        {
            releaseDate = tempReleaseDate;
        }

        public string getSupplierInfo()
        {
            return supplierInfo;
        }

        public void setSupplierInfo(string tempSupplierInfo)
        {
            supplierInfo = tempSupplierInfo;
        }

        public long getIsbn()
        {
            return isbn;
        }

        public void setIsbn(long tempIsbn)
        {
            isbn = tempIsbn;
        }

        public float getPrice()
        {
            return price;
        }

        public void setPrice(float tempPrice)
        {
            price = tempPrice;
        }
    }
}
