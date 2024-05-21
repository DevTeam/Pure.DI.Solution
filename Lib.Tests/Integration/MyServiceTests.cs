using Moq;
using Pure.DI;

namespace Lib.Tests.Integration;

public partial class MyServiceTests
{
    private readonly Mock<IOutput> _output = new();
    private readonly Mock<IInput> _input = new();
    
    [Fact]
    public void ShouldAskToPressEnter()
    {
        // Given
        
        // When
        Service.Run();

        // Then
        _output.Verify(i => i.WriteLine("Hello!"));
        _output.Verify(i => i.WriteLine("Press the Enter key to exit."));
    }
    
    [Fact]
    public void ShouldWaitForEnter()
    {
        // Given
        
        // When
        Service.Run();

        // Then
        _input.Verify(i => i.ReadLine());
    }

    private void Setup() =>
        DI.Setup(nameof(MyServiceTests))
            // Based on the Composition setup from the Lib namespace
            .DependsOn("Lib.Composition")
            // Overrides some instances using mocks
            .Bind<IOutput>().To(_ => _output.Object)
            .Bind<IInput>().To(_ => _input.Object)
            // Exposing a test instance as the composition root 
            .Root<IService>("Service");
}