# Simple library management system
This project provides a console library management system written in C#. It includes functionality for managing a collection of books, such as adding new books, displaying books, searching for books by title, updating book details, removing books, and saving/loading the book collection to/from a file.

This exercise was made to help me understand basic C# concepts and get comfortable with the language's syntax and object-oriented programming.

# Documentation and screenshots of console
<img width="698" alt="Console-menu-library" src="https://github.com/user-attachments/assets/29e83903-b3ed-4a0c-ae35-69eac7bfac22">

## Usage
The program is executed via the program.cs file, which interacts with the Library class to provide a console-based user interface for managing the library.
Main Menu Options:
- Add a new book
- Display all books
- Search for a book by title
- Remove a book
- Update a book's details
- Save library to file
- Load library from file
- Exit (saves the library to the file before exiting)

## Book list
The file 'library-book-list.txt' contains a list of books with their details in the following format: Title,Author,ISBN,PublishedYear. For example: "To Kill a Mockingbird",Harper Lee,9780060935467,1960.

## Book class
The Book class represents a book in the library. It contains properties such as Title, Author, ISBN, and PublishedYear to store details about each book.

## Library class
The Library class manages a collection of Book objects and provides various methods to interact with this collection.


### Add new book
<img width="290" alt="Console-menu-library3" src="https://github.com/user-attachments/assets/d0bea889-e26e-4292-89dc-603e30278038">

AddNewBook(Book book) adds a new book to the library.
- book (Book): The book to add to the library.
- Output: Prints a success message to the console.


### Display all books
<img width="698" alt="Console-menu-library" src="https://github.com/user-attachments/assets/29e83903-b3ed-4a0c-ae35-69eac7bfac22">

DisplayBooks() displays all books currently in the library.
- Output: Lists the details of each book or indicates that the library is empty.


### Search for book by title
<img width="619" alt="Console-menu-library2" src="https://github.com/user-attachments/assets/5e6f6ee8-0c65-4395-a684-4aeb82fad9b2">

SearchBookByTitle(string title) searches for books by their title.
- Parameters: title (string): The title or part of the title to search for.
- Output: Displays the books that match the search criteria or indicates that no matches were found.


### Remove book
Removes a book from the library based on its ISBN.
- Parameters: isbn (string): The ISBN of the book to remove.
- Output: Prints a success message if the book is removed or indicates that no matching book was found.


### Update book
UpdateBook(string isbn, string newTitle, string newAuthor, int newPublishedYear) updates the details of an existing book in the library.
- isbn (string): The ISBN of the book to update.
- newTitle (string): The new title for the book.
- newAuthor (string): The new author for the book.
- newPublishedYear (int): The new publication year for the book.
- Output: Prints the updated book details or indicates that the book was not found.


### Save to file
SaveToFile() saves the current book collection to a file.
- Output: Writes the book details to a file and prints a success message, or an error message if something goes wrong.


### Load books from file
LoadBooksFromFile() loads the book collection from a file.
- Output: Reads the book details from the file and loads them into the library. Prints a success message after loading.
