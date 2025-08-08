using System;


namespace LibraryManagmentSystem
{
    internal class LibraryUser : User
    {
        int LibraryUserId;
        bool flag=false;

        public LibraryUser()
        {
            LibraryUserId++;
        }
        public void Borrow(string t,Library l)

        {
            Book b1=new Book();
            bool flag = false;
            foreach (Book item in l.Books) {
                        if(item.Title== t)
                {
                    b1 = item;
                    flag=true;
                    break;
                }
            }
            if (flag)
            {
                l.BorowedBooks.Add(b1);
                Console.WriteLine("Booked successfully..");
            }
            else
            {
                Console.WriteLine("Could't find this book .. try again");
            }
        }

        public void Display(Library l)
        {
            l.DisplayBooks();
        }

        public void DisplayBorrowed(Library l)
        {
            l.DisplayBorrowedBooks();
        }
    }
}
