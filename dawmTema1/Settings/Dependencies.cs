using dawmTema1.Repositories;
using dawmTema1.Services;

namespace dawmTema1.Settings
{
    public static class Dependencies
    {
        public static void Inject(WebApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Services.AddControllers();
            applicationBuilder.Services.AddSwaggerGen();

            AddRepositories(applicationBuilder.Services);
            AddServices(applicationBuilder.Services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<ClientService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<ClientsRepository>();
        }
    }

}
