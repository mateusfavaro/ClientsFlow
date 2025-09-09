using ClientsFlow.Application.UseCases.Clients.Register;
using Microsoft.Extensions.DependencyInjection;

namespace ClientsFlow.Application
{
    public static class DependencyInjectionExtension
    {

        public static void AddApplication(this IServiceCollection services)
        {
            AddUseCase(services);
        }


        private static void AddUseCase(IServiceCollection services)
        {
            services.AddScoped<IRegisterClientUseCase, RegisterClientUseCase>();
        }

    }
}
