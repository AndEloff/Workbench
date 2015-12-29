using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace AssignmentFour
{
    class MovieManager
    {
        List<Movie> movieList = new List<Movie>();

        public void AddMovie(Movie movieToBeAdded)
        {
            movieList.Add(movieToBeAdded);
        }

        public void RemoveMovie(Movie movieToBeRemoved)
        {
            movieList.Remove(movieToBeRemoved);
        }

        public List<Movie> FindMovieByTitle(string title)
        {
            List<Movie> results = new List<Movie>();
            return results;
        }

        public List<Movie> FindMovieByDirector(string director)
        {
            List<Movie> results = new List<Movie>();
            return results;
        }

        public List<Movie> FindMovieByGenre(string genre)
        {
            List<Movie> results = new List<Movie>();
            return results;
        }

        public void EditMovieTitle(Movie movieToEdit, string title)
        {
            movieToEdit.setTitle(title);
        }

        public void EditMovieGenre(Movie movieToEdit, string genre)
        {
            movieToEdit.setGenre(genre);
        }

        public void EditMovieDirector(Movie movieToEdit, string director)
        {
            movieToEdit.setDirector(director);
        }

        public List<Movie> MovieList()
        {
            List<Movie> results = new List<Movie>();
            return results;
        }

        public void Serialize()
        {
            using (FileStream stream = new FileStream(@"C:\Users\NewbSmasher\Documents\MovieFile.txt", FileMode.Create))
            using (TextWriter writer = new StreamWriter(stream))
            {
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\NewbSmasher\Documents\MovieFile.txt", true))
            {
                for (int i = 0; i < movieList.Count; i++)
                {
                    file.WriteLine(movieList[i].getTitle());
                    file.WriteLine(movieList[i].getDirector());
                    file.WriteLine(movieList[i].getGenre());
                    file.WriteLine(movieList[i].getReleaseDate());
                    file.WriteLine(movieList[i].getSupplierInfo());
                    file.WriteLine(movieList[i].getPrice());
                }
            }
        }

        public void print()
        {
             for (int i = 0; i < movieList.Count; i++)
             {
                  Console.WriteLine(movieList[i].getTitle());
                  Console.WriteLine(movieList[i].getDirector());
                  Console.WriteLine(movieList[i].getGenre());
                  Console.WriteLine(movieList[i].getReleaseDate());
                  Console.WriteLine(movieList[i].getSupplierInfo());
                  Console.WriteLine(movieList[i].getPrice());
             }
        }

        public void Load()
        {

             try
             {
                  // Create an instance of StreamReader to read from a file.
                  // The using statement also closes the StreamReader.
                  using (StreamReader sr = new StreamReader(@"C:\Users\NewbSmasher\Documents\MovieFile.txt"))
                  {
                       String line;
                       // Read and display lines from the file until the end of
                       // the file is reached.
                       int i = 0;
                       Movie tempMovie = new Movie();
                       while ((line = sr.ReadLine()) != null)
                       {
                            if (i == 0)
                            {
                                 tempMovie.setTitle(line);
                            }
                            if (i == 1)
                            {
                                 tempMovie.setDirector(line);
                            }
                            if (i == 2)
                            {
                                 tempMovie.setGenre(line);
                            }
                            if (i == 3)
                            {
                                 tempMovie.setReleaseDate(line);
                            }
                            if (i == 4)
                            {
                                 tempMovie.setSupplierInfo(line);
                            }
                            if (i == 5)
                            {
                                 tempMovie.setPrice((float)System.Convert.ToDouble(line));
                                 this.AddMovie(tempMovie);
                                 tempMovie = new Movie();
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