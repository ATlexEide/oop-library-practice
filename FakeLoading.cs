using static System.Console;
using System.Threading;
using static Library;
public class FakeLoading
{
    public List<Book> books;
    public FakeLoading(List<Books> _books){
        books = _books;
    }
public void FakeLoad(int bookAmount = 10)
{
    Random _int = new Random();
        int index = 0;
        int step = 100 / books.Length;
        int currStep = step;
        String message = "#";
    for (int i = 0; i < 100; i++)
    {
        if(i == currStep){
            WriteLine("step");
            currStep += step;
            index++;
            Thread.Sleep(1000);
            WriteLine($"{AvailableBooks[index].title}");
    };

        
        message += "#";
    Clear();
    WriteLine(message);
    Thread.Sleep(_int.Next(1,100));
    };
}
}