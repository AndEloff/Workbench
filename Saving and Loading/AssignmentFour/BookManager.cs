using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace AssignmentFour
{
    class BookManager
    {

        List<Book> bookList = new List<Book>();

        public void AddBook(Book bookToBeAdded)
        {
            bookList.Add(bookToBeAdded);
        }

        public void RemoveBook(Book bookToBeRemoved)
        {
            bookList.Remove(bookToBeRemoved);
        }

        public List<Book> FindBookByTitle(string title)
        {
            List<Book> results = new List<Book>();
            return results;
        }

        public List<Book> FindBookByAuthor(string author)
        {
            List<Book> results = new List<Book>();
            return results;
        }

        public List<Book> FindBookByGenre(string genre)
        {
            List<Book> results = new List<Book>();
            return results;
        }

        public void EditBookTitle(Book bookToEdit, string title)
        {
            bookToEdit.setTitle(title);
        }

        public void EditBookGenre(Book bookToEdit, string genre)
        {
            bookToEdit.setGenre(genre);
        }

        public void EditBookAuthor(Book bookToEdit, string author)
        {
            bookToEdit.setAuthor(author);
        }

        public List<Book> BookList()
        {
            List<Book> results = new List<Book>();
            return results;
        }

        public void Serialize()
        {
            using (FileStream stream = new FileStream(@"C:\Users\NewbSmasher\Documents\BookFile.txt", FileMode.Create))
            using (TextWriter writer = new StreamWriter(stream))
            {

            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\NewbSmasher\Documents\BookFile.txt", true))
            {
                for (int i = 0; i < bookList.Count; i++)
                {
                    file.WriteLine(bookList[i].getTitle());
                    file.WriteLine(bookList[i].getAuthor());
                    file.WriteLine(bookList[i].getGenre());
                    file.WriteLine(bookList[i].getReleaseDate());
                    file.WriteLine(bookList[i].getSupplierInfo());
                    file.WriteLine(bookList[i].getIsbn());
                    file.WriteLine(bookList[i].getPrice());
                }
            }
        }

        public void print()
        {
             for (int i = 0; i < bookList.Count; i++)
             {
                  Console.WriteLine(bookList[i].getTitle());
                  Console.WriteLine(bookList[i].getAuthor());
                  Console.WriteLine(bookList[i].getGenre());
                  Console.WriteLine(bookList[i].getReleaseDate());
                  Console.WriteLine(bookList[i].getSupplierInfo());
                  Console.WriteLine(bookList[i].getIsbn());
                  Console.WriteLine(bookList[i].getPrice());
             }
        }

        public void Load()
        {

             try
             {
                  // Create an instance of StreamReader to read from a file.
                  // The using statement also closes the StreamReader.
                  using (StreamReader sr = new StreamReader(@"C:\Users\NewbSmasher\Documents\BookFile.txt"))
                  {
                       String line;
                       // Read and display lines from the file until the end of
                       // the file is reached.
                       int i = 0;
                       Book tempBook = new Book();
                       while ((line = sr.ReadLine()) != null)
                       {
                            if (i == 0)
                            {
                                 tempBook.setTitle(line);
                            }
                            if (i == 1)
                            {
                                 tempBook.setAuthor(line);
                            }
                            if (i == 2)
                            {
                                 tempBook.setGenre(line);
                            }
                            if (i == 3)
                            {
                                 tempBook.setReleaseDate(line);
                            }
                            if (i == 4)
                            {
                                 tempBook.setSupplierInfo(line);
                            }
                            if (i == 5)
                            {
                                 tempBook.setIsbn((long)System.Convert.ToDouble(line));
                            }
                            if (i == 6)
                            {
                                 tempBook.setPrice((float)System.Convert.ToDouble(line));
                                 this.AddBook(tempBook);
                                 tempBook = new Book();
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
