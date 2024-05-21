namespace Lib;

public class MyService(
    ILog<MyService> log,
    IInput input,
    IOutput output)
    : IService
{
    public void Run()
    {
        log.Info("Running...");
        
        output.WriteLine("Hello!");

        output.WriteLine("Press the Enter key to exit.");
        input.ReadLine();
    }
}