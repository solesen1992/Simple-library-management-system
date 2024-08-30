using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simple_library_management_system
{
    /**
     * Library class that contains a collection of Book objects.
     */
    internal class Library
    {
        private List<Book> books;

        /**
         * Constructor
         */
        public Library()
        {
            books = new List<Book>;
        }

        /**
         * Add a new book to the library
         */
        public void AddBookToLibrary(Book book) {
            books.Add(book);
            Console.WriteLine("Book added succesfully to the library!");
        }

        /**
         * Display all books in the library
         */
        public void DisplayBooks() {
            if (books == null)
            {
                Console.WriteLine("There's no books in the library");
            }
            else
            {
                foreach (Book book in books) {
                    Console.WriteLine(book.ToString());
                }

            }


        }

        /**
        * Search for books by title
        */
        public void SearchForBooksByTitle(string title) {

        }
    }
}
    