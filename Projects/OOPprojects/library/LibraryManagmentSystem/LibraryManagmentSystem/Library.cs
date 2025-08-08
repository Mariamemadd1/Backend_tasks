using System;
namespace LibraryManagmentSystem
{
    internal class Library
    {
        public int cnt;
        public List<Book> Books=new List<Book>(100);
        public List<Book> BorowedBooks = new List<Book>(50);
        public void AddBooks(Book B)
        {
            if (cnt < 100)
            {
                Books.Add(B);
                cnt++;
                Console.WriteLine("Book Added Successfully..");
            }
            else
            {
                Console.WriteLine("Can't Add books");
            }

        }
        Book b;
        bool Search(string t)
        {
                foreach (Book book in Books)
                {
                    if (book.Title == t)
                    {
                        b = book;
                        return true;
                    }
                }
            return false; 
        }

        public void RemoveBooks(string T)
        {   if(Search(T)) { 
                Books.Remove(b);
                b = null;
                cnt--;
                Console.WriteLine("Book removed successfully ..");
            }
            else
            {
                Console.WriteLine("Couldn't find Your item .. ");
            }
        }

        public void DisplayBooks()
        {
            foreach (Book item in Books)
            {
                Console.WriteLine($"{item.Title}");
            }
        }

        public void DisplayBorrowedBooks()
        {
            foreach (Book item in BorowedBooks)
            {
                Console.WriteLine($"{item.Title}");
            }
        }
    }
}
