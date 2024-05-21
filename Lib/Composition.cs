using Pure.DI;
using static Pure.DI.Lifetime;

namespace Lib;

internal partial class Composition
{
    private static void Setup() => 
        DI.Setup(nameof(Composition), CompositionKind.Internal)
            .Bind().To<Log<TT>>()
            .Bind().As(Singleton).To<ConsoleAdapter>()
            .Bind().To<MyService>();
}