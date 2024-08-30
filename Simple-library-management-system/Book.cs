using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_library_management_system
{
    internal class Book
    {
        private string title;
        private string author;
        private string iSBN;
        private int publishedYear;

        /**
         * Constructor
         */
        public Book(string title, string author, string iSBN, int publishedYear)
        {
            this.title = title;
            this.author = author;
            this.iSBN = iSBN;
            this.publishedYear = publishedYear;
        }

        /**
         * Getters and setters
         */
        public string Title {
            get { return title; }
            set { title = value; }
        }

        public string Author {
            get { return author; }
            set { author = value; }
        
        }
        public string ISBN {
            get { return iSBN; }
            set { iSBN = value; }
        }

        public int PublishedYear {
            get { return publishedYear; }
            set { publishedYear = value; }
        }

        /**
         * To string
         * Override the ToString method to display the book details in a readable format.
         */
        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Published Year: {PublishedYear}";
        }
    }
}
