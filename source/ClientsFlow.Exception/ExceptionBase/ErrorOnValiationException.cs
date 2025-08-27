
namespace ClientsFlow.Exception.ExceptionBase
{
    public class ErrorOnValidationException : ClientsFlowException
    {

        public List<string> Errors {get;}
        public ErrorOnValidationException(List<string> errorMessages)
        {

            Errors = errorMessages;
        }
    }
}
