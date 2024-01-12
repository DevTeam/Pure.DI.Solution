using Lib;
using Composition = PackageRefApp.Composition;

var composition = new Composition();
return composition.Root.Run(args);

internal partial class Program(IInput input, IOutput output)
{
    private int Run(string[] args)
    {
        output.WriteLine("Hello!");

        output.WriteLine("Press the Enter key to exit.");
        input.ReadLine();

        return 0;
    }
}