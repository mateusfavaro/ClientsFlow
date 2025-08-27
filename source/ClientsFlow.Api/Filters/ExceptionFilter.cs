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
            if (context.Exception is ErrorOnValidationException)
            {

                var ex = (ErrorOnValidationException)context.Exception;

                var response = new ResponseErrorJson
                {
                    ErrorMessage = ex.Errors
                };

                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Result = new BadRequestObjectResult(response);
            }
        }

        private void ThrowUnknowError(ExceptionContext context)
        {

            var error = new List<string>();
            error.Add("UnknownError");

            var errorReponse = new ResponseErrorJson
            {
                ErrorMessage = error
            };

            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(errorReponse);
        }

    }
}
