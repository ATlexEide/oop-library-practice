using Microsoft.VisualBasic;
using static System.Console;


public class Book
{
    public string Title;
    public string Author;
    public DateTime  Release;
    public void PrintInfo(){
        WriteLine($"Title // {Title}");
        WriteLine($"Author // {Author}");
        WriteLine($"Release date // {Release}");
    }

    public Book(string title, string author, DateTime release = new DateTime())
    {
        Title = title;
        Author = author;
        Release = release;
    }
}