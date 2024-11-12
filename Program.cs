using System.Security.Cryptography;

namespace oop;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Press any key to make a library");
        Console.ReadKey();
        Console.Clear();
        String LibraryName = getLibraryName();
        Console.Clear();
        Library userLibrary = new Library(LibraryName);
        static string getLibraryName(){
        Console.WriteLine("Enter a name for your Library");
            String userInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userInput)){
                Console.Clear();
                Console.WriteLine("Invalid name, cannot be empty");
                return getLibraryName();
            }
            else{
                return userInput;
            }
        }
        Console.WriteLine($"Your new library \"{LibraryName}\" is ready!");
        Console.WriteLine($"Press any key to get started");
        Console.ReadKey();
        userLibrary.openMenu();
        Console.ReadKey();
  
    }
}
