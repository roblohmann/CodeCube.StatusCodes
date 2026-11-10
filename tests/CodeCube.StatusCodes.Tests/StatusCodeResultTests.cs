using CodeCube.StatusCodes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Xunit;

namespace CodeCube.StatusCodes.Tests
{
    public class StatusCodeResultTests
    {
        [Fact]
        public void BadGatewayResult_WithValue_Sets502AndValue()
        {
            var result = new BadGatewayResult("upstream failed");

            Assert.Equal(502, result.StatusCode);
            Assert.Equal("upstream failed", result.Value);
        }

        [Fact]
        public void InternalServerErrorResult_WithValue_Sets500AndValue()
        {
            var result = new InternalServerErrorResult("boom");

            Assert.Equal(500, result.StatusCode);
            Assert.Equal("boom", result.Value);
        }

        [Fact]
        public void BadGatewayResult_WithModelState_Sets502AndKeepsModelState()
        {
            var modelState = new ModelStateDictionary();
            modelState.AddModelError("Name", "Required");

            var result = new BadGatewayResult(modelState);

            Assert.Equal(502, result.StatusCode);
            Assert.Same(modelState, result.Value);
        }

        [Fact]
        public void InternalServerErrorResult_WithModelState_Sets500AndKeepsModelState()
        {
            var modelState = new ModelStateDictionary();
            modelState.AddModelError("Name", "Required");

            var result = new InternalServerErrorResult(modelState);

            Assert.Equal(500, result.StatusCode);
            Assert.Same(modelState, result.Value);
        }

        [Fact]
        public void Results_AreObjectResults()
        {
            Assert.IsAssignableFrom<ObjectResult>(new BadGatewayResult("x"));
            Assert.IsAssignableFrom<ObjectResult>(new InternalServerErrorResult("x"));
        }
    }
}
