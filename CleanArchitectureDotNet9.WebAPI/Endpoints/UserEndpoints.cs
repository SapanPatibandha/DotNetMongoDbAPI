using CleanArchitectureDotNet9.Application.Repository.UserRepository;
using CleanArchitectureDotNet9.Domain.Entities;

namespace CleanArchitectureDotNet9.WebAPI.Endpoints
{
    public static class UserEndpoints
    {
        public static void MapUserEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPost("/users", async (User user, IUserRepository userRepository) =>
            {
                await userRepository.AddAsync(user);
                return Results.Created($"/users/{user.Id}", user);
            }).WithTags("Users");
        }
    }
}
