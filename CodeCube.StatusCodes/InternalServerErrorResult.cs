using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CodeCube.StatusCodes
{
    public sealed class InternalServerErrorResult : ObjectResult
    {
        private const int DefaultStatusCode = (int)HttpStatusCode.InternalServerError;

        public InternalServerErrorResult(object value) : base(value)
        {
            StatusCode = DefaultStatusCode;
        }

        public InternalServerErrorResult(ModelStateDictionary modelState) : base(modelState)
        {
            StatusCode = DefaultStatusCode;
        }
    }
}