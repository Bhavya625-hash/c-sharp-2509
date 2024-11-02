using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__abstract_classes
{
    public class Library

    {

        Book[] books = new Book[4];

        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
        public void DisplayBooks(Library library)
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Title:{library[i].Title},Author:{library[i].Author}");

            }
        }
    }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public Book(string title,string author)
              {

                 Title = title;
                 Author = author;
               }
        }    
}
