using Microsoft.VisualBasic;

public class Book
{
    public string Title;
    public string Author;
    public DateTime  Release;
    public void PrintInfo(){
        Console.WriteLine($"Title // {Title}");
        Console.WriteLine($"Author // {Author}");
        Console.WriteLine($"Release date // {Release}");
    }

    public Book(string title, string author, DateTime release = new DateTime())
    {
        Title = title;
        Author = author;
        Release = release;
    }
}