# CodeCube.StatusCodes
Small library which allows you to use objectresults for the InternalServerError and BadGateway statuscodes.

![Nuget](https://img.shields.io/nuget/dt/CodeCube.StatusCodes?style=for-the-badge)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/CodeCube.StatusCodes?style=for-the-badge)
![GitHub](https://img.shields.io/github/license/roblohmann/CodeCube.StatusCodes?style=for-the-badge)

## Example .NET Core 3.x

### Implementation in an base API-controller
```csharp
public abstract class BaseAPIController : ControllerBase
{
    protected static InternalServerErrorObjectResult InternalServerError(string message)
    {
        return new InternalServerErrorObjectResult(message);
    }

    protected static InternalServerErrorObjectResult InternalServerError(ModelStateDictionary modelState)
    {
        return new InternalServerErrorObjectResult(modelState);
    }

    protected static InternalServerErrorResult InternalServerError()
    {
        return new InternalServerErrorResult();
    }    



    protected static BadGatewayObjectResult BadGateway(string message)
    {
        return new BadGatewayObjectResult(message);
    }

    protected static BadGatewayObjectResult BadGateway(ModelStateDictionary modelState)
    {
        return new BadGatewayObjectResult(modelState);
    }

    protected static BadGatewayResult BadGateway()
    {
        return new BadGatewayResult();
    }    
}
```

### Example Usage in API Controller

```csharp
public class MyAPIController : BaseAPIController
{
    public async Task<IActionResult> MyAction()
    {
        return InternalServerError("Some errormessage");
    }

    public async Task<IActionResult> MySecondAction()
    {
        return BadGateway("Some errormessage");
    }
}
```
