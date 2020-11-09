using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CodeCube.StatusCodes
{
    public sealed class BadGatewayResult : StatusCodeResult
    {
        public BadGatewayResult() : base((int)HttpStatusCode.BadGateway)
        {

        }
    }

    public sealed class BadGatewayObjectResult : ObjectResult
    {
        public BadGatewayObjectResult(object value) : base(value)
        {
            StatusCode = (int)HttpStatusCode.BadGateway;
        }

        public BadGatewayObjectResult(ModelStateDictionary modelState) : base(modelState)
        {
            StatusCode = (int)HttpStatusCode.BadGateway;
        }
    }
}