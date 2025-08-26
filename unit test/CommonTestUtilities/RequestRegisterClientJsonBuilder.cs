using Bogus;
using ClientsFlow.Communication.Enums;
using ClientsFlow.Communication.Requests;

namespace CommonTestUtilities
{
    public class RequestRegisterClientJsonBuilder
    {

        public static RequestRegisterClientJson Build()
        {

            return new Faker<RequestRegisterClientJson>()
                .RuleFor(r => r.ClientName, faker => faker.Name.FirstName())
                .RuleFor(r => r.AmountCharged, faker => faker.Random.Decimal(min: 1, max: 3000))
                .RuleFor(r => r.ServiceDescription, faker => faker.Commerce.ProductDescription())
                .RuleFor(r => r.AreaOfActivity, faker => faker.PickRandom<AreaOfActivity>());

        }
    }
}
