# Agilent.Ace.Testables.Process

This package contains an abstraction of the `System.Process` class found in .NET Framework 4.8 and .NET 8.0. It allows for an `IProcessFactory` interface to be used instead and for mocks to be created.

## Usage

1. Pass `IProcessFactory` as a dependency _via_ the constructor into the class you want to test:
```csharp
public class TestableClass
{
    private readonly IProcessFactory _processFactory;

    public TestableClass(IProcessFactory processFactory)
    {
        _processFactory = processFactory;
    }

    public void DoWork()
    {
        _processFactory.Start(...);
    }
}
```
2. In your IOC Container register `IProcess` and `Agilent.Ace.Testables.Process`:
```csharp
_services.AddTransient<IProcess, ProcessWrapper>();
```
3. In your tests, verify that the correct method and args are called:
```csharp
[TestMethod]
public void Should_StartProcess_When_DoWorkPerformed()
{
    // Arrange
    var mockProcessFactory = new Mock<IProcessFactory>();
    var sut = new TestableClass(mockProcessFactory.Object);

    // Act
    sut.DoWork();

    // Assert
    mockProcessFactory.Verify(x => x.Start(...), Times.Once);
}
```
