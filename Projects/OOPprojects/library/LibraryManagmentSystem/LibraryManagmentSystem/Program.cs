namespace LibraryManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------Welcome To Memo's Library-------------------------");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"User or Librarian? (L\U)");

            Library library = new Library();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            char choice = Console.ReadLine().ToUpper()[0];

            string name;
            switch (choice)
            {   

                case 'L':
                    Lib:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("What's Your Name ?");

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    name = Console.ReadLine();

                Librarian u1 = new Librarian()
                {
                    Name = name
                };

                Console.WriteLine($"Welcome {u1.Name}");

                while (true)
                {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(@"Add or Remove  or Display Books (A\R\D) switch to user (S)");

                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        char c = Console.ReadLine().ToUpper()[0];

                    switch (c)
                    {
                        case 'A':
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Book Title : ");

                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            string BookTitle = Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("\nAuthor Name : ");

                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            string Author = Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("\nPublishedYear : ");

                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            string Year = Console.ReadLine();

                            Book book = new Book()
                            {
                                Title = BookTitle,
                                AuthorName = Author,
                                PublishedYear = Year
                            };

                            u1.Add(book, library);
                            break;

                        case 'R':
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Enter book title : ");

                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            string bt = Console.ReadLine();

                            u1.Remove(bt, library);
                            break;
                        case 'D':
                            u1.DisplayBooks(library);
                            break;

                            case 'S':
                                goto Start;
                                break;
                        default:
                            Console.WriteLine("GoodBye...");
                            Environment.Exit(1);
                            break;
                    }
                }
                break;

            case 'U':
                    Start:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("What's Your Name ?");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                name = Console.ReadLine();


                LibraryUser lu = new LibraryUser()
                {
                    Name = name
                };

                Console.WriteLine($"Welcome {lu.Name}");

                while (true)
                {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(@"Borrow or Display Books or Display Borrowed (B\D\K) , switch to librarian (s)");

                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        char c = Console.ReadLine().ToUpper()[0];

                    switch (c)
                    {
                            case 'B':
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("Enter Book Title : ");

                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                string bt = Console.ReadLine();

                                lu.Borrow(bt,library);
                                break;

                            case 'K':
                                lu.DisplayBorrowed(library);
                                break;
                            case 'D':
                                lu.Display(library);
                                break;

                            case 'S':
                                goto Lib;
                                break;
                            default:
                                Console.WriteLine("GoodBye...");
                                Environment.Exit(1);
                                break;
                        }
                }
                break;
            }
        }
    }
}
    
