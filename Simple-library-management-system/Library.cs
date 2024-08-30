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
        // Path to the file with books
        private string filePath = @"C:\Datamatiker\visual-studio-workspace\Simple-library-management-system\Simple-library-management-system\library-book-list.txt";


        /**
         * Constructor
         */
        public Library()
        {
            books = new List<Book>();
        }

        /**
         * Add a new book to the library
         */
        public void AddNewBook (Book book) {
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
        public void SearchBookByTitle (string title) {
            // A list to store the found books
            List<Book> foundBooks = new List<Book>();
            // Convert the search title to lowercase to ensure case-insensitive comparison
            string searchTitle = title.ToLower();

            // Loops through each book in the books collection
            foreach (Book book in books)
                {
                    // Convert the book title to lowercase for case-insensitive comparison
                    if (book.Title.ToLower().Contains(searchTitle))
                    {
                        // Prints out the books title that is about to be added
                        Console.WriteLine($"Adding book: {book.Title}");

                        // Add the book to the found books collection
                        foundBooks.Add(book);

                    }
                }

            if (foundBooks.Count == 0)
            {
                // If no books where found with the specified title
                Console.WriteLine("No books where found with the specified title");
            }
            else {
                // Print details of the found books
                foreach (var book in foundBooks)
                {
                    Console.WriteLine(book.ToString());
                }
                Console.WriteLine($"{foundBooks.Count} book(s) found.");
            }
        }

        /**
         * Removing a book from the book list / library
         */
        public void RemoveBook(string isbn) {
            // To store the book we want to remove
            Book bookToRemove = null;

            // Loop through each book in the 'books' collection to find the one with the matching ISBN
            foreach (Book book in books)
            {
                // Check if the current books ISBN matches the specified ISBN
                if (book.ISBN == isbn)
                {
                    // If a match is found, assign the book we want to remove to the variable.
                    bookToRemove = book;
                    break;
                }
            }

            // Check if a book was found
            if (bookToRemove != null)
            {
                // Remove the book from the books collection
                books.Remove(bookToRemove);
                Console.WriteLine("Book was removed ssuccesfully");
            }
            else {
                // If no book was found, print a message
                Console.WriteLine("No book was found or removed");
            }
        }

        /**
         * Updating book details 
         */
        public void UpdateBook(string isbn, string newTitle, string newAuthor, int newPublishedYear) {
            // Store the book that needs to be updated
            Book bookToUpdate = null;

            // Loop through each book in the 'books' collection to find the one with the matching ISBN
            foreach (Book book in books)
            {
                // Check if the current book's ISBN matches the specified ISBN
                if (book.ISBN == isbn) {
                    // If a match is found, assign it to 'bookToUpdate' and break out of the loop
                    bookToUpdate = book;
                    break;
                }
            }

            // Check if a book was found in the loop above
            if (bookToUpdate != null)
            {
                // If a book was found, update its details
                bookToUpdate.Title = newTitle;
                bookToUpdate.Author = newAuthor;
                bookToUpdate.PublishedYear = newPublishedYear;
                Console.Write("Book details updated succesfully. The new details are: Title: " + bookToUpdate.Title + " Author: " + bookToUpdate.Author
                    + " Published year: " + bookToUpdate.PublishedYear);
            }
            else {
                //If no books where found
                Console.WriteLine("Book not found");
            }

        }

        /**
         * Saving book collection to a file 
         */
        public void SaveToFile(string filePath) {
            // Create a StreamWriter object to write to the specified file
            StreamWriter writer = null;

            try
            {
                // Initialize the StreamWriter to write to the specified file path
                writer = new StreamWriter(filePath);

                // Loop through each book in the 'books' collection
                foreach (var book in books)
                {
                    // Write the book's details to the file, with each property separated by a comma
                    string line = book.Title + "," + book.Author + "," + book.ISBN + "," + book.PublishedYear.ToString();
                    writer.WriteLine(line);
                }

                // Print a success message after all books have been written to the file
                Console.WriteLine("Library saved to file successfully.");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur and print an error message
                Console.WriteLine("An error occurred while saving to file: " + ex.Message);
            }
            finally
            {
                // Ensure that the StreamWriter is properly closed, even if an exception occurs
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        /**
        * Loading book list from a file 
        */
        public void LoadBooksFromFile() { 
            // Ensure the books list is empty before loading new data
            books.Clear();

            // Use the filePath defined in the class
            // The 'using' statement ensures that the StreamReader is properly disposed of after use
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Declare a variable to hold each line read from the file
                string line;

                // Loop through each line in the file until the end is reached
                while ((line = reader.ReadLine()) != null) {
                    // Split the line into parts using a comma as the delimiter
                    // This assumes the format of each line is Title,Author,ISBN,PublishedYear
                    string[] parts = line.Split(',');

                    // Check if the line contains exactly 4 parts (Title, Author, ISBN, PublishedYear)
                    if (parts.Length == 4) {
                        // Create a new Book object using the constructor
                Book book = new Book(
                    parts[0],                // Title
                    parts[1],                // Author
                    parts[2],                // ISBN
                    int.Parse(parts[3])      // PublishedYear
                );

                        // Add the newly created Book object to the books list
                        books.Add(book);

                    }
                }
            }

            // Print a message to the console indicating that the library has been successfully loaded
            Console.WriteLine("Library loaded from file successfully.");
        }
    }
}
    