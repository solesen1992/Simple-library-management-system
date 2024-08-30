// See https://aka.ms/new-console-template for more information

using Simple_library_management_system;

Library library = new Library();

const string filePath = @".\Simple-library-management-system\library-book-list.txt";

// Load library data from file at the start
library.LoadBooksFromFile();

while (true)
{
    Console.WriteLine("\nLibrary Management System");
    Console.WriteLine("1. Add a new book");
    Console.WriteLine("2. Display all books");
    Console.WriteLine("3. Search for a book by title");
    Console.WriteLine("4. Remove a book");
    Console.WriteLine("5. Update a book's details");
    Console.WriteLine("6. Save library to file");
    Console.WriteLine("7. Load library from file");
    Console.WriteLine("8. Exit");
    Console.Write("Enter your choice: ");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddNewBook(library);
            break;
        case "2":
            library.DisplayBooks();
            break;
        case "3":
            SearchBookByTitle(library);
            break;
        case "4":
            RemoveBook(library);
            break;
        case "5":
            UpdateBook(library);
            break;
        case "6":
            library.SaveToFile(filePath);
            break;
        case "7":
            library.LoadBooksFromFile();
            break;
        case "8":
            // Save library data before exiting
            library.SaveToFile(filePath);
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}

static void AddNewBook(Library library) {
    Console.Write("Enter book title: ");
    string title = Console.ReadLine();
    Console.Write("Enter book author: ");
    string author = Console.ReadLine();
    Console.Write("Enter book ISBN: ");
    string isbn = Console.ReadLine();
    Console.Write("Enter book published year: ");
    int publishedYear = int.Parse(Console.ReadLine());

    Book newBook = new Book(title, author, isbn, publishedYear);
    library.AddNewBook(newBook);
}

static void SearchBookByTitle(Library library) {
    Console.Write("Enter the title to search for: ");
    string title = Console.ReadLine();
    library.SearchBookByTitle(title);
}

static void RemoveBook(Library library)
{
    Console.Write("Enter the ISBN of the book to remove: ");
    string isbn = Console.ReadLine();
    library.RemoveBook(isbn);
}

static void UpdateBook(Library library)
{
    Console.Write("Enter the ISBN of the book to update: ");
    string isbn = Console.ReadLine();

    Console.Write("Enter new title: ");
    string newTitle = Console.ReadLine();
    Console.Write("Enter new author: ");
    string newAuthor = Console.ReadLine();
    Console.Write("Enter new published year: ");
    int newPublishedYear = int.Parse(Console.ReadLine());

    library.UpdateBook(isbn, newTitle, newAuthor, newPublishedYear);
}