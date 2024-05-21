using Lib;

var composition = new App.Composition();
return composition.Root.Run(args);

internal partial class Program(IService service)
{
    private int Run(string[] args)
    {
        service.Run();
        return 0;
    }
}