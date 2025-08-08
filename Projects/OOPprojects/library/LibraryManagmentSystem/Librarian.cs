using System;


namespace LibraryManagmentSystem
{
    internal class Librarian : User
    {
        int LibrarianId;

        public Librarian()
        {
            LibrarianId++;
        }

        public void Add(Book B,Library L)
        {
            L.AddBooks(B);
        }
        public void Remove(string B, Library L)
        {
            L.RemoveBooks(B);
        }

        public void DisplayBooks(Library L) { 
            L.DisplayBooks();
        }

        public void DisplayBorrowed(Library l)
        {
            l.DisplayBorrowedBooks();
        }
    }
}
