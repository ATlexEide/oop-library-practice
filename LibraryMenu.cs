public class Menu
{
    string[] Options = [
        "List available books",
        "Add book to library",
        "Lend a book"
    ];
    public Menu()
    {

    }
    public void open(){
        Console.Clear();
         Console.WriteLine(LibraryName);
         Console.WriteLine("///BOOKS//////BOOKS//////BOOKS//////BOOKS//////BOOKS///");
         Console.WriteLine("Library interaction menu:");
        // Options
            int Index = 0;
        foreach (String option in MenuOptions)
        {
            Console.WriteLine($"{Index} - {option}");
            Index++;
        }
        int selected = selectOption();
        runOption(selected);
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
        public void runOption(int selected){
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
            runOption(selected);
        }else{
            AvailableBooks.Add(new Book(title, author));
            openMenu();
        }
            
        break;
        case 2:
       Console.Clear();
            Console.WriteLine("Hmmm, seems functionality is missing..");
            Console.WriteLine("/////////////////////////");
        Console.WriteLine("Press any key to go back");
        Console.ReadKey();
        openMenu();
        break;
      }
    }
 
}