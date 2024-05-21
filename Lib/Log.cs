namespace Lib;

public class Log<T>(IOutput output) : ILog<T>
{
    public void Info(string message) => 
        output.WriteLine($"{typeof(T)}: {message}");
}