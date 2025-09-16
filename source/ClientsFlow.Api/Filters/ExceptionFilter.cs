using ClientsFlow.Communication.Responses;
using ClientsFlow.Exception.ExceptionBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ClientsFlow.Api.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {

            if(context.Exception is ClientsFlowException)
            {
                HandleProjectException(context);
            }
            else
            {
                ThrowUnknowError(context);
            }
        }

        private void HandleProjectException(ExceptionContext context)
        {
            if (context.Exception is ErrorOnValidationException errorOnValidationException)
            {
                var errorResponse = new ResponseErrorJson(errorOnValidationException.Errors);

                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Result = new BadRequestObjectResult(errorResponse);
            }

            else if (context.Exception is NotFoundException NotFoundException)
            {

                var errorMessage = new ResponseErrorJson(NotFoundException.Message);

                context.HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                context.Result = new BadRequestObjectResult(errorMessage);
            }
            else
            {
                var errorResponse = new ResponseErrorJson(context.Exception.Message);

                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Result = new BadRequestObjectResult(errorResponse);
            }
        }
        private void ThrowUnknowError(ExceptionContext context)
        {

            var error = new List<string>();
            error.Add("UnknownError");

            var errorReponse = new ResponseErrorJson(string.Empty)
            {
                ErrorMessage = error

            };

            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(errorReponse);
        }

    }
}
