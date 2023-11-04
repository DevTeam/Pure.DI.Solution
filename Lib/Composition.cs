using Pure.DI;
using static Pure.DI.Lifetime;

namespace Lib;

internal class Composition
{
    private static void Setup() => 
        DI.Setup(nameof(Composition), CompositionKind.Global)
            .Bind<IInput>().Bind<IOutput>().As(Singleton).To<ConsoleAdapter>();
}