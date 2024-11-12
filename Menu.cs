public class Menu
{
    public string LibraryName;
    public List<Book> Books;
    public string[] Options = [
        "List available books",
        "Add book to library",
        "Lend a book"
    ];
    public Menu(string name, List<Book> books)
    {
        LibraryName = name;
        Books = books;
    }
    public void Open(){
        Console.Clear();
         Console.WriteLine(LibraryName);
         Console.WriteLine("///BOOKS//////BOOKS//////BOOKS//////BOOKS//////BOOKS///");
         Console.WriteLine("Library interaction menu:");
        // Options
            int Index = 0;
        foreach (String option in Options)
        {
            Console.WriteLine($"{Index} - {option}");
            Index++;
        }
        int selected = SelectOption();
        RunOption(selected);
    }
    public int SelectOption(){
        var input = Console.ReadKey();
        if(char.IsDigit(input.KeyChar)){
        return int.Parse(input.KeyChar.ToString());
        }else{
            Console.Clear();
            Console.WriteLine("Not valid input");
            return SelectOption();
        }
    }
        public void RunOption(int selected){
      switch (selected)
      {
        case 0:
            Console.Clear();
            ListAvailableBooks();
        break;
        case 1:
        Console.Clear();
        Console.WriteLine("Enter book title:");
        String title = Console.ReadLine();
        Console.WriteLine("Enter book author:");
        String author = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
        {
            Console.WriteLine("Title and author can not be empty");
            Console.ReadKey();            
            RunOption(selected);
        }else{
            Books.Add(new Book(title, author));
            Open();
        }
            
        break;
        case 2:
       Console.Clear();
            Console.WriteLine("Hmmm, seems functionality is missing..");
            Console.WriteLine("/////////////////////////");
        Console.WriteLine("Press any key to go back");
        Console.ReadKey();
        Open();
        break;
      }
    }
    public void ListAvailableBooks(){
        Books.ForEach((book) => Console.WriteLine($"{book.Title} by {book.Author}"));
        Console.WriteLine("/////////////////////////");
        Console.WriteLine("Press any key to go back");
        Console.ReadKey();
        Open();
    }
 
}