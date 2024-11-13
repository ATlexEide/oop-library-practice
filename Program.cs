using System.Security.Cryptography;
using static System.Console;

namespace oop;
class Program
{
    static void Main(string[] args)
    {
        Clear();
        WriteLine("Press any key to make a library");
        ReadKey();
        Clear();
        String LibraryName = getLibraryName();
        Clear();
        Library userLibrary = new Library(LibraryName);
        static string getLibraryName(){
        WriteLine("Enter a name for your Library");
            String userInput = ReadLine();
            if (string.IsNullOrWhiteSpace(userInput)){
                Clear();
                WriteLine("Invalid name, cannot be empty");
                return getLibraryName();
            }
            else{
                return userInput;
            }
        }
        WriteLine($"Your new library \"{LibraryName}\" is ready!");
        WriteLine($"Press any key to get started");
        ReadKey();
        userLibrary.Menu.Open();  
    }
}
