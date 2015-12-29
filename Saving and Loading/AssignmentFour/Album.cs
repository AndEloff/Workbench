using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentFour
{
    class Album
    {
        private string title, artist, recordLabel, releaseDate, supplierInfo;
        private float price;

        public Album()
        {

        }

        public Album(string _artist, string _title, string _label, string _date, string _info, float _price)
        {
            title = _title;
            artist = _artist;
            recordLabel = _label;
            releaseDate = _date;
            supplierInfo = _info;
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

        public string getArtist()
        {
            return artist;
        }

        public void setArtist(string tempArtist)
        {
            artist = tempArtist;
        }

        public string getRecordLabel()
        {
            return recordLabel;
        }

        public void setRecordLabel(string tempRecordLabel)
        {
            recordLabel = tempRecordLabel;
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
