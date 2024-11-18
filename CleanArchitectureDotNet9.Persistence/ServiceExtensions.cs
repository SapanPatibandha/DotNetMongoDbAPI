using CleanArchitectureDotNet9.Application.Repository.UserRepository;
using CleanArchitectureDotNet9.Persistence.Repository.UserRepository;
using CleanArchitectureDotNet9.Persistence.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace CleanArchitectureDotNet9.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var section = configuration.GetSection("MongoDB");

            var mongoConfig = section.Get<MongoSettings>();
            var mongoClient = new MongoClient(mongoConfig.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(mongoConfig.DatabaseName);

            services.AddSingleton(mongoDatabase);
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
