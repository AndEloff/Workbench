using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentFour
{
    public class Movie
    {
        private string title, director, genre, releaseDate, supplierInfo;
        private float price;

        public Movie()
        {
        }

        public Movie(string _title, string _director, string _genre, string _releaseDate, string _supplierInfo, float _price)
        {
            title = _title;
            director = _director;
            genre = _genre;
            releaseDate = _releaseDate;
            supplierInfo = _supplierInfo;
            price = _price;
        }

        public string getTitle()
        {
            return title;
        }

        public void setTitle(string tempTitle)
        {
            title = tempTitle;
        }

        public string getDirector()
        {
            return director;
        }

        public void setDirector(string tempDirector)
        {
            director = tempDirector;
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
