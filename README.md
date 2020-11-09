# CodeCube.StatusCodes
Small library which allows you to use 

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



    protected static BadGatewayObjectResult BadeGateway(string message)
    {
        return new BadGatewayObjectResult(message);
    }

    protected static BadGatewayObjectResult BadeGateway(ModelStateDictionary modelState)
    {
        return new BadGatewayObjectResult(modelState);
    }

    protected static BadGatewayResult BadeGateway()
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
