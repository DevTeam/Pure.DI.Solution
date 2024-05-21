using Moq;

namespace Lib.Tests.Unit;

public class MyServiceTests
{
    private readonly Mock<IOutput> _output = new();
    private readonly Mock<IInput> _input = new();
    
    [Fact]
    public void ShouldAskToPressEnter()
    {
        // Given
        var service = CreateInstance();
        
        // When
        service.Run();

        // Then
        _output.Verify(i => i.WriteLine("Hello!"));
        _output.Verify(i => i.WriteLine("Press the Enter key to exit."));
    }

    [Fact]
    public void ShouldWaitForEnter()
    {
        // Given
        var service = CreateInstance();
        
        // When
        service.Run();

        // Then
        _input.Verify(i => i.ReadLine());
    }

    private MyService CreateInstance() => 
        new(
            Mock.Of<ILog<MyService>>(),
            _input.Object,
            _output.Object);
}