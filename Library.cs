public class Library
{
    string LibraryName;
    String[] MenuOptions = [
        "List available books",
        "Add book to library",
        "Lend a book"
    ];
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
        AvailableBooks.ForEach((book) => Console.WriteLine(book.Title));
    }
    public void openMenu(){
        Console.Clear();
         Console.WriteLine("Library interaction menu:");
        // Options
            int Index = 0;
        foreach (String option in MenuOptions)
        {
            Index++;
            Console.WriteLine($"{Index} - {option}");
        }
        int selected = selectOption();
        Console.WriteLine(selected);
    }
    public int selectOption(){
        var input = Console.ReadKey();
        if(char.IsDigit(input.KeyChar)){
        return int.Parse(input.KeyChar.ToString());
        }else{
            Console.Clear();
            Console.WriteLine("Not valid input");
            return selectOption();
        }
    }
}