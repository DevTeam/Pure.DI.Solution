using Pure.DI;

namespace PackageRefApp;

internal partial class Composition
{
    private static void Setup() => 
        DI.Setup(nameof(Composition))
            .Root<Program>("Root");
}