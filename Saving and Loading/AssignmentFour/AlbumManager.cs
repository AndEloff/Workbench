using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace AssignmentFour
{
    class AlbumManager
    {
        List<Album> albumList = new List<Album>();

        public void AddAlbum(Album albumToBeAdded)
        {
            albumList.Add(albumToBeAdded);
        }

        public void RemoveAlbum(Album albumToBeRemoved)
        {
            albumList.Remove(albumToBeRemoved);
        }

        public List<Album> FindAlbumByTitle(string title)
        {
            List<Album> results = new List<Album>();
            return results;
        }

        public List<Album> FindAlbumByArtist(string artist)
        {
            List<Album> results = new List<Album>();
            return results;
        }

        public List<Album> FindAlbumByRecordLabel(string recordLabel)
        {
            List<Album> results = new List<Album>();
            return results;
        }

        public void EditAlbumTitle(Album albumToEdit, string title)
        {
            albumToEdit.setTitle(title);
        }

        public void EditAlbumRecordLabel(Album albumToEdit, string recordLabel)
        {
            albumToEdit.setRecordLabel(recordLabel);
        }

        public void EditAlbumArtist(Album albumToEdit, string artist)
        {
            albumToEdit.setArtist(artist);
        }

        public List<Album> AlbumList()
        {
            List<Album> results = new List<Album>();
            return results;
        }

        public void Serialize()
        {
            using (FileStream stream = new FileStream(@"C:\Users\NewbSmasher\Documents\AlbumFile.txt", FileMode.Create))
            using (TextWriter writer = new StreamWriter(stream))
            {
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\NewbSmasher\Documents\AlbumFile.txt", true))
            {
                for (int i = 0; i < albumList.Count; i++)
                {
                    file.WriteLine(albumList[i].getArtist());
                    file.WriteLine(albumList[i].getTitle());
                    file.WriteLine(albumList[i].getRecordLabel());
                    file.WriteLine(albumList[i].getReleaseDate());
                    file.WriteLine(albumList[i].getSupplierInfo());
                    file.WriteLine(albumList[i].getPrice());
                }
            }
        }

        public void print()
        {
             for (int i = 0; i < albumList.Count; i++)
             {
                  Console.WriteLine(albumList[i].getArtist());
                  Console.WriteLine(albumList[i].getTitle());
                  Console.WriteLine(albumList[i].getRecordLabel());
                  Console.WriteLine(albumList[i].getReleaseDate());
                  Console.WriteLine(albumList[i].getSupplierInfo());
                  Console.WriteLine(albumList[i].getPrice());
             }
        }

        public void Load()
        {

             try
             {
                  // Create an instance of StreamReader to read from a file.
                  // The using statement also closes the StreamReader.
                  using (StreamReader sr = new StreamReader(@"C:\Users\NewbSmasher\Documents\AlbumFile.txt"))
                  {
                       String line;
                       // Read and display lines from the file until the end of
                       // the file is reached.
                       int i = 0;
                       Album tempAlbum = new Album();
                       while ((line = sr.ReadLine()) != null)
                       {
                            if (i == 0)
                            {
                                 tempAlbum.setArtist(line);
                            }
                            if (i == 1)
                            {
                                 tempAlbum.setTitle(line);
                            }
                            if (i == 2)
                            {
                                 tempAlbum.setRecordLabel(line);
                            }
                            if (i == 3)
                            {
                                 tempAlbum.setReleaseDate(line);
                            }
                            if (i == 4)
                            {
                                 tempAlbum.setSupplierInfo(line);
                            }
                            if (i == 5)
                            {
                                 tempAlbum.setPrice((float)System.Convert.ToDouble(line));
                                 this.AddAlbum(tempAlbum);
                                 tempAlbum = new Album();
                                 i = -1;
                            }
                            i = i + 1;
                       }
                  }
             }
             catch (Exception e)
             {
                  // Let the user know what went wrong.
                  Console.WriteLine("The file could not be read:");
                  Console.WriteLine(e.Message);
             }

        }
    }
}
