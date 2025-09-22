namespace Oop;

public interface IConsoleTool
{
    public void Write(string message);
    public void WriteEmptyLine();
    public void WriteError(string message);
}

public class ConsoleTool : IConsoleTool
{
    public void PrintInfo()
    {
        Console.WriteLine("I am a console tool.");
    }
    
    public void Write(string message)
    {
        Console.WriteLine(message);
    }

    public void WriteEmptyLine()
    {
        Console.WriteLine();
    }

    public void WriteError(string message)
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = previousColor;
    }
}