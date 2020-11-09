using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CodeCube.StatusCodes
{
    public sealed class InternalServerErrorResult : StatusCodeResult
    {
        public InternalServerErrorResult() : base((int)HttpStatusCode.InternalServerError)
        {
            
        }
    }

    public sealed class InternalServerErrorObjectResult : ObjectResult
    {
        public InternalServerErrorObjectResult(object value) : base(value)
        {
            StatusCode = (int) HttpStatusCode.InternalServerError;
        }

        public InternalServerErrorObjectResult(ModelStateDictionary modelState) : base(modelState)
        {
            StatusCode = (int)HttpStatusCode.InternalServerError;
        }
    }
}