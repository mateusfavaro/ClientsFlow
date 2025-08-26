using ClientsFlow.Communication.Enums;


namespace ClientsFlow.Communication.Requests
{
    public class RequestRegisterClientJson
    {

        public string ClientName { get; set; } = string.Empty;

        public AreaOfActivity AreaOfActivity { get; set; }

        public decimal AmountCharged { get; set; }

        public string ServiceDescription { get; set; } = string.Empty;




    }
}
