using static System.Console;


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
        Clear();
         WriteLine(LibraryName);
         WriteLine("///BOOKS//////BOOKS//////BOOKS//////BOOKS//////BOOKS///");
         WriteLine("Library interaction menu:");
        // Options
            int Index = 0;
        foreach (String option in Options)
        {
            WriteLine($"{Index} - {option}");
            Index++;
        }
        int selected = SelectOption();
        RunOption(selected);
    }
    public int SelectOption(){
        var input = ReadKey();
        if(char.IsDigit(input.KeyChar)){
        return int.Parse(input.KeyChar.ToString());
        }else{
            Clear();
            WriteLine("Not valid input");
            return SelectOption();
        }
    }
        public void RunOption(int selected){
      switch (selected)
      {
        case 0:
            Clear();
            ListAvailableBooks();
        break;
        case 1:
        Clear();
        WriteLine("Enter book title:");
        String title = ReadLine();
        WriteLine("Enter book author:");
        String author = ReadLine();
        if(string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
        {
            WriteLine("Title and author can not be empty");
            ReadKey();            
            RunOption(selected);
        }else{
            Books.Add(new Book(title, author));
            Open();
        }
            
        break;
        case 2:
       Clear();
            WriteLine("Hmmm, seems functionality is missing..");
            WriteLine("/////////////////////////");
        WriteLine("Press any key to go back");
        ReadKey();
        Open();
        break;
      }
    }
    public void ListAvailableBooks(){
        Books.ForEach((book) => WriteLine($"{book.Title} by {book.Author}"));
        WriteLine("/////////////////////////");
        WriteLine("Press any key to go back");
        ReadKey();
        Open();
    }
 
}