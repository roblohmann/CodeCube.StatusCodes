using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CodeCube.StatusCodes
{
    public sealed class BadGatewayResult : StatusCodeResult
    {
        public BadGatewayResult() : base((int)HttpStatusCode.BadGateway)
        {
        }

        public StatusCodeResult BadGateway()
        {
            return new StatusCodeResult((int)HttpStatusCode.BadGateway);
        }

        public ObjectResult BadGateway(object value)
        {
            return new ObjectResult(value)
            {
                StatusCode = (int)HttpStatusCode.BadGateway
            };
        }
    }
}