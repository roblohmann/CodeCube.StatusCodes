using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CodeCube.StatusCodes
{
    public sealed class InternalServerErrorResult : StatusCodeResult
    {
        public InternalServerErrorResult() : base((int)HttpStatusCode.InternalServerError)
        {
        }

        public StatusCodeResult InternalServerError()
        {
            return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
        }

        public ObjectResult InternalServerError(object value)
        {
            return new ObjectResult(value)
            {
                StatusCode = (int)HttpStatusCode.InternalServerError
            };
        }
    }
}