using MediatR;

namespace CleanArchitectureDotNet9.Application.Features.UserFeatures.Add
{
    public sealed record AddUserRequest(string Email, string Name) : IRequest<AddUserResponse>;
}
