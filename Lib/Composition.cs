using Pure.DI;
using static Pure.DI.Lifetime;

namespace Lib;

internal partial class Composition
{
    [System.Diagnostics.Conditional("DI")]
    private static void Setup() => 
        DI.Setup(nameof(Composition), CompositionKind.Internal)
            .Bind<IInput>().Bind<IOutput>().As(Singleton).To<ConsoleAdapter>();
}