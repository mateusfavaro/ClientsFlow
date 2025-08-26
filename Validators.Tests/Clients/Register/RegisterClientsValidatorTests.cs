using ClientsFlow.Application.UseCases.Clients.Register;
using CommonTestUtilities;

namespace Validators.Tests.Clients.Register
{
    public class RegisterClientsValidatorTests
    {

        [Fact]
        public void Sucess()
        {
            //Arrange
            var validator = new RegisterClientsValidator();
            var request = RequestRegisterClientJsonBuilder.Build();

            //Act
            var result = validator.Validator(request);

            //Assert
            Assert.False(result);
        }

    }
}
