using static System.Console;
using System.Threading;
using static Library;
public class FakeLoading
{
    public List<Book> books;
    public FakeLoading(){
    }
public void FakeLoad(int num = 10)
{
    Random _int = new Random();
        int index = 0;
        int step = 100 / num;
        int currStep = step;
        String message = "#";
    for (int i = 0; i < 100; i++)
    {
        if(i == currStep){
            WriteLine("step");
            currStep += step;
            index++;
            Thread.Sleep(1000);
            // WriteLine($"{Books[index].title}");
    };

        
        message += "#";
    Clear();
    WriteLine(message);
    Thread.Sleep(_int.Next(1,100));
    };
}
}