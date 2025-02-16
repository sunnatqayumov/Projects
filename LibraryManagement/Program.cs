using System;
using System.Collections.Generic;
using Spectre.Console;

// Abstract class and interfaces
public abstract class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }

    public LibraryItem(string title, string author, string isbn, int publicationYear)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
    }
    public LibraryItem() { }
}

public interface IBorrowable
{
    string Borrow();
    string Return();
}

public interface ISearchable
{
    bool Search(string query);
}

// Book class
public class Book : LibraryItem, IBorrowable, ISearchable
{
    public bool isBorrowed;

    public Book(string title, string author, string isbn, int publicationYear)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
        isBorrowed = false;
    }

    public override string ToString()
    {
        return $"Book: {Title} by {Author}, ISBN: {ISBN}, Year: {PublicationYear}, Borrowed: {isBorrowed}";
    }

    public string Borrow()
    {
        if(isBorrowed)
        {
            return "The book is already borrowed.";
        }
        isBorrowed = true;
        return "Book borrowed successfully.";
    }

    public string Return()
    {
        if (!isBorrowed)
        {
            return "The book was not borrowed.";
        }
        isBorrowed = false;

        return "Book returned successfully.";
    }

    public bool Search(string query)
    {
        return Title.Contains(query) ||
               Author.Contains(query) ||
               ISBN.Contains(query);
    }
}

// Magazine class
public class Magazine : LibraryItem, ISearchable
{
    public int IssueNumber { get; set; }

    public Magazine(string title, string author, string isbn, int publicationYear, int issueNumber)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
        IssueNumber = issueNumber;
    }

    public override string ToString()
    {
        return $"Magazine: {Title} by {Author}, ISBN: {ISBN}, Year: {PublicationYear}, Issue: {IssueNumber}";
    }

    public bool Search(string query)
    {
        return Title.Contains(query) || Author.Contains(query) || ISBN.Contains(query);
    }
}

// Library class
public class Library
{
    private List<LibraryItem> items = new List<LibraryItem>();

    public void AddItem(LibraryItem item)
    {
        items.Add(item);
    }

    public void DisplayAvailableItems()
    {
        var table = new Table();
        table.Border(TableBorder.Rounded);
        
        table.AddColumn("[yellow]Title[/]");
        table.AddColumn("[yellow]Author[/]");
        table.AddColumn("[yellow]ISBN[/]");
        table.AddColumn("[yellow]Publication Year[/]");
        table.AddColumn("[yellow]Additional Info[/]");

        foreach(var item in items)
        {
            if(item is Book book)
            {
                table.AddRow
                (
                    book.Title,
                    book.Author,
                    book.ISBN,
                    book.PublicationYear.ToString(),
                    $"[Green]Borrowed: {((IBorrowable)book).Borrow() == "Book borrowed successfully."}[/]"
                );
            }
            else if(item is Magazine magazine)
            {
                table.AddRow
                (
                    magazine.Title,
                    magazine.Author,
                    magazine.ISBN,
                    magazine.PublicationYear.ToString(),
                    $"Issue Number: {magazine.IssueNumber}"
                );
            }
        }
        AnsiConsole.Write(table);
    }

    public LibraryItem? FindItemByISBN(string isbn)
    {
        var item = items.Find(i => i.ISBN == isbn);
        return item;
    }

    public void SearchItems(string query)
    {
        foreach (var item in items)
        {
            if(item is ISearchable searchable && searchable.Search(query))
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

class Programm
{
    static void Main()
    {
        Library library = new Library();

        library.AddItem(new Book("Xamsa", "Alisher Navai", "111111", 1444));
        library.AddItem(new Magazine("Saodat Asri Qissalari", "Axmad Lutfiy", "777777", 2000, 5));
        library.AddItem(new Book("Tafsiri Xilol", "Shayx Muhammad Sodiq Muhammad Yusuf", "110011", 2001));

        bool search = true;
        while(search)
        {
            AnsiConsole.Write(
                            new FigletText("Library Management")
                            .Centered()
                            .Color(Color.DarkRed));
            var choice = AnsiConsole.Prompt
            (
                new SelectionPrompt<string>()
                    .Title("[green] \nEnter your choice[/]:")
                    .PageSize(10)
                    .MoreChoicesText("[Red](Move up and down to reveal more choices)[/]")
                    .AddChoices(new[]
                    {
                        " ", "1. Add Book📘", "2. Add Magazine➕", "3. Display Available Items📚",
                        "4. Borrow a Book🤝", "5. Return a Book📑", "6. Search Items📊",
                        "7. Exit❗️",
                    }));
                switch(choice)
                {
                    case "1. Add Book📘":

                       AnsiConsole.Write(
                        new FigletText("Add Book")
                            .Centered()
                            .Color(Color.DarkRed));

                    Console.Write("Enter book title: ");
                    string bookTitle = Console.ReadLine()!;
                    Console.Write("Enter author: ");
                    string bookAuthor = Console.ReadLine()!;
                    Console.Write("Enter ISBN: ");
                    string bookISBN = Console.ReadLine()!;
                    Console.Write("Enter publication year: ");
                    int bookYear = int.Parse(Console.ReadLine()!);
                    library.AddItem(new Book(bookTitle, bookAuthor, bookISBN, bookYear));

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Book added succsessfully");
                    Console.ResetColor();
                    break;

                    case "2. Add Magazine➕":

                        AnsiConsole.Write(
                            new FigletText("Add Magazine")
                            .Centered()
                            .Color(Color.DarkRed));

                    Console.Write("Enter magazine title: ");
                    string magTitle = Console.ReadLine()!;
                    Console.Write("Enter author: ");
                    string magAuthor = Console.ReadLine()!;
                    Console.Write("Enter ISBN: ");
                    string magISBN = Console.ReadLine()!;
                    Console.Write("Enter publication year: ");
                    int magYear = int.Parse(Console.ReadLine()!);
                    Console.Write("Enter issue number: ");
                    int issueNumber = int.Parse(Console.ReadLine()!);
                    library.AddItem(new Magazine(magTitle, magAuthor, magISBN, magYear, issueNumber));

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Magazine added succsessfully");
                    Console.ResetColor();
                    break;

                case "3. Display Available Items📚":

                    AnsiConsole.Write(
                        new FigletText("Display Available Items")
                            .Centered()
                            .Color(Color.DarkRed));

                    library.DisplayAvailableItems();
                    break;

                case "4. Borrow a Book🤝":

                    AnsiConsole.Write(
                        new FigletText("Borrow A Book")
                            .Centered()
                            .Color(Color.DarkRed));

                    Console.Write("Enter the ISBN of the book to borrow: ");
                    string borrowISBN = Console.ReadLine()!;
                    var borrowBook = library.FindItemByISBN(borrowISBN!) as IBorrowable;

                    Console.ForegroundColor = ConsoleColor.Green;
                    if(borrowBook != null)
                    {
                        Console.WriteLine(borrowBook.Borrow());
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                    Console.ResetColor();
                    break;

                case "5. Return a Book📑":

                    AnsiConsole.Write(
                        new FigletText("Return A Book")
                            .Centered()
                            .Color(Color.DarkRed));

                    Console.Write("Enter the ISBN of the book to return: ");
                    string returnISBN = Console.ReadLine()!;
                    var returnBook = library.FindItemByISBN(returnISBN!) as IBorrowable;
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    if(returnBook != null)
                    {
                        Console.WriteLine(returnBook.Return());
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                    Console.ResetColor();
                    break;

                case "6. Search Items📊":

                    AnsiConsole.Write(
                        new FigletText("Search Items")
                            .Centered()
                            .Color(Color.DarkRed));

                    Console.Write("Enter search query: ");
                    string query = Console.ReadLine()!;
                    library.SearchItems(query!);
                    break;

                case "7. Exit❗️":

                    AnsiConsole.Write(
                        new FigletText("Exit.....")
                            .Centered()
                            .Color(Color.DarkRed));

                    search = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}