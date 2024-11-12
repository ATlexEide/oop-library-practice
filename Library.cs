using System.ComponentModel.Design;
using System.Reflection.Metadata;

public class Library
{
    string LibraryName;
    LibraryMenu Menu = new LibraryMenu();
    public List<Book> AvailableBooks;
    public Library(string name)
    {
        LibraryName = name;
        AvailableBooks = new List<Book>();
        AvailableBooks.Add(new Book("TESTING", "also Alex", new DateTime()));
        AvailableBooks.Add(new Book("TESTING 4 DUMMIES", "Alex again", new DateTime()));
    }

    public Book? LendBook(string title)
    {        
        Book? book = AvailableBooks.Find(book => book.Title == title);
        Console.WriteLine($"Lending you {book}");
        return book;
    }
       public void ListAvailableBooks(){
        AvailableBooks.ForEach((book) => Console.WriteLine($"{book.Title} by {book.Author}"));
        Console.WriteLine("/////////////////////////");
        Console.WriteLine("Press any key to go back");
        Console.ReadKey();
        openMenu();
    }

}