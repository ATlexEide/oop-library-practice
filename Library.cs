using System.ComponentModel.Design;
using System.Reflection.Metadata;
using static System.Console;


public class Library
{
    public string LibraryName;
    public Menu Menu;
    public List<Book> AvailableBooks;
    public Library(string name)
    {
        LibraryName = name;
        AvailableBooks = new List<Book>();
        AvailableBooks.Add(new Book("TESTING", "also Alex", new DateTime()));
        AvailableBooks.Add(new Book("TESTING 4 DUMMIES", "Alex again", new DateTime()));
        Menu = new Menu(LibraryName, AvailableBooks);
    }

    public Book? LendBook(string title)
    {        
        Book? book = AvailableBooks.Find(book => book.Title == title);
        WriteLine($"Lending you {book}");
        return book;
    }
    public void Loading(){
      FakeLoading ldn = new FakeLoading();
      ldn.FakeLoad(AvailableBooks.Count); 
    }
       

}