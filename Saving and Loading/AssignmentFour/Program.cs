using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentFour
{
    class Program
    {
        static void Main(string[] args)
        {
            AlbumManager albumManager = new AlbumManager();
            MovieManager movieManager = new MovieManager();
            BookManager bookManager = new BookManager();

            Console.WriteLine("What would you like to edit.  1-Album, 2-Book, 3-Movie");
            int q = 0;
            q = System.Convert.ToInt32(Console.ReadLine());

            //Do album stuff
            if (q == 1)
            {
                 int a = 0;
                 Console.WriteLine("Would you like to save or load?  (1 for save, 2 for load)");
                 a = System.Convert.ToInt32(Console.ReadLine());

                 //Save and serialize. (Album)
                 if (a == 1)
                 {
                      Console.WriteLine("How many albums would you like to add?");
                      int b = 0;
                      b = System.Convert.ToInt32(Console.ReadLine());

                      for (int i = 0; i < b; i++)
                      {

                           Console.WriteLine("What is the Artist? ");
                           string artistInput = Console.ReadLine();

                           Console.WriteLine("What is the Title? ");
                           string titleInput = Console.ReadLine();

                           Console.WriteLine("What is the Record Label? ");
                           string recordInput = Console.ReadLine();

                           Console.WriteLine("What is the Release Date? ");
                           string releaseInput = Console.ReadLine();

                           Console.WriteLine("What is the Supplier Information? ");
                           string supplierInput = Console.ReadLine();

                           Console.WriteLine("What is the Price? ");
                           float priceInput = (float)System.Convert.ToDouble(Console.ReadLine());

                           Album newAlbum = new Album(artistInput, titleInput, recordInput, releaseInput, supplierInput, priceInput);
                           albumManager.AddAlbum(newAlbum);
                      }

                      albumManager.Serialize();
                 }

                 //Load and Print (Album)
                 if (a == 2)
                 {
                      Console.WriteLine("These are the albums in the file");
                      albumManager.Load();
                      albumManager.print();
                 }
                 Console.ReadLine();
            }

            if (q == 2)
            {
                 int a = 0;
                 Console.WriteLine("Would you like to save or load?  (1 for save, 2 for load)");
                 a = System.Convert.ToInt32(Console.ReadLine());

                 //Save and serialize. (Book)
                 if (a == 1)
                 {
                      Console.WriteLine("How many books would you like to add?");
                      int b = 0;
                      b = System.Convert.ToInt32(Console.ReadLine());

                      for (int i = 0; i < b; i++)
                      {
                           Console.WriteLine("What is the Book Title? ");
                           string bookTitleInput = Console.ReadLine();

                           Console.WriteLine("What is the Book Author? ");
                           string bookAuthor = Console.ReadLine();

                           Console.WriteLine("What is the Book Genre? ");
                           string bookGenre = Console.ReadLine();

                           Console.WriteLine("When is the Book Release Date? ");
                           string releaseInput = Console.ReadLine();

                           Console.WriteLine("What is the Book's Supplier Information? ");
                           string supplierInput = Console.ReadLine();

                           Console.WriteLine("What is the Book ISBN number? ");
                           long isbn = (long)System.Convert.ToDouble(Console.ReadLine());

                           Console.WriteLine("What is the Book's Price? ");
                           float priceInput = (float)System.Convert.ToDouble(Console.ReadLine());
                           Book newBook = new Book(bookTitleInput, bookAuthor, bookGenre, releaseInput, supplierInput, isbn, priceInput);
                           bookManager.AddBook(newBook);
                      }

                      bookManager.Serialize();

                 }

                 //Load and Print (Book)
                 if (a == 2)
                 {
                      Console.WriteLine("These are the books in the file");
                      bookManager.Load();
                      bookManager.print();
                 }
                 Console.ReadLine();
            }

            if (q == 3)
            {
                 int a = 0;
                 Console.WriteLine("Would you like to save or load?  (1 for save, 2 for load)");
                 a = System.Convert.ToInt32(Console.ReadLine());

                 //Save and serialize. (Album)
                 if (a == 1)
                 {
                      Console.WriteLine("How many albums would you like to add?");
                      int b = 0;
                      b = System.Convert.ToInt32(Console.ReadLine());

                      for (int i = 0; i < b; i++)
                      {

                           Console.WriteLine("What is the Title? ");
                           string movieTitleInput = Console.ReadLine();

                           Console.WriteLine("What is the Director? ");
                           string directorInput = Console.ReadLine();

                           Console.WriteLine("What is the Genre? ");
                           string genreInput = Console.ReadLine();

                           Console.WriteLine("What is the Release Date? ");
                           string releaseInput = Console.ReadLine();

                           Console.WriteLine("What is the Supplier Information? ");
                           string supplierInput = Console.ReadLine();

                           Console.WriteLine("What is the Price? ");
                           float priceInput = (float)System.Convert.ToDouble(Console.ReadLine());
                           Movie newMovie = new Movie(movieTitleInput, directorInput, genreInput, releaseInput, supplierInput, priceInput);
                           movieManager.AddMovie(newMovie);
                      }

                      movieManager.Serialize();
                 }

                 //Load and Print (Album)
                 if (a == 2)
                 {
                      Console.WriteLine("These are the movies in the file");
                      movieManager.Load();
                      movieManager.print();
                 }
                 Console.ReadLine();
            }
        }
    }
}
