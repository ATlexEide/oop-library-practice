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
    public void openMenu(){
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
}