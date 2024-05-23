using Pure.DI;

namespace App;

internal partial class Composition
{
    private static void Setup() => DI.Setup()
            // Based on the Composition setup from the Lib namespace
            .DependsOn("Lib.Composition")
            .Root<Program>("Root");
}