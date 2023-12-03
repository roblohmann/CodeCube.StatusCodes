using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CodeCube.StatusCodes
{
    public sealed class BadGatewayResult : ObjectResult
    {
        public BadGatewayResult(object value) : base(value)
        {
            StatusCode = (int)HttpStatusCode.BadGateway;
        }

        public BadGatewayResult(ModelStateDictionary modelState) : base(modelState)
        {
            StatusCode = (int)HttpStatusCode.BadGateway;
        }
    }
}