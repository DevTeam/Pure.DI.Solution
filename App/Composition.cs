using Pure.DI;

namespace App;

internal partial class Composition
{
    [System.Diagnostics.Conditional("DI")]
    private static void Setup() => 
        DI.Setup(nameof(Composition))
            .DependsOn($"{nameof(Lib)}.{nameof(Lib.Composition)}")
            .Root<Program>("Root");
}