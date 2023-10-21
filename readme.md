# Base objects for domain layer
## Introduction
This library help us to increase the speed for develop objects for domain layer, providing interfaces and classes for that.  
## How to install
For installing this package, you must execute the following command:  
```
dotnet add package accelerate.domain
```
## How to use
### Writing a custom data transfer object
``` csharp
public class MyModel : Model
{
    private Boolean _disposed;

    // Declare properties to expose

    /// <inherithdoc />
    protected override void Dispose(Boolean disposing)
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(GetType().Name);
        }

        base.Dispose(disposing);

        if (disposing)
        {
            // Free yours resources memory allocation
        }

        _disposed = true;
    }
}
```
### Writing a custom service
``` csharp
public class MyService : DomainService
{
    private Boolean _disposed;

    /// <summary>
    /// Initialize a new instance of <seealso cref="MyService" /> class.
    /// </summary>
    protected MyService()
    {
    }

    // Declare methods to expose

    /// <inherithdoc />
    protected override void Dispose(Boolean disposing)
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(GetType().Name);
        }

        base.Dispose(disposing);

        if (disposing)
        {
            // Free yours resources memory allocation
        }

        _disposed = true;
    }
}
```
## Changes history
**Version 1.0.0**
- Include interfaces and base classes for models and services.  
