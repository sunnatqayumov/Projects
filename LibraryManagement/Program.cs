using System;
using System.Collections.Generic;

public abstract class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear  { get; set; }

    protected LibraryItem(string title, string author, string isbn, int publicationYear)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
    }
    public abstract void Display();
}
public class Book : LibraryItem, IBorrowable, ISearchable
{
    public bool IsBorrowed { get; private set; }

    public bool Borrow(out string message)
    {
        if(IsBorrowed)
        {
            message = "Kitob allaqachon olingan!";
            return false;
        }

        IsBorrowed = true;
        message = "Kitob muvaffaqiyatli olingan!";                                   
        return true;
    }

    public bool Return(string message)
    {
        if(!IsBorrowed)
        {
            message = "Kitob qaytarish uchun olinmagan!";
            return false;
        }

        IsBorrowed = false;
        message = "Kitob muvaffaqiyatli qaytarildi!";
        return true;
    }

    public override void Display()
    {
        Console.WriteLine($"Kitob: {Title}, Muallif: {Author}, ISBN: {ISBN}, Nashir yili: {PublicationYear}");
    }
}
public interface IBorrowable
{
    void Borrow();
    void Return();
}

public class Book : LibraryItem, IBorrowable, ISearchable
{
    void IBorrowable.Borrow()
    {
        // Borrowing logic
    }

    void IBorrowable.Return()
    {
        // Returning logic
    }
}
