using AutoMapper;
using CleanArchitectureDotNet9.Application.Repository.UserRepository;
using CleanArchitectureDotNet9.Domain.Entities;
using MediatR;

namespace CleanArchitectureDotNet9.Application.Features.UserFeatures.Add
{
    public sealed class AddUserHandler : IRequestHandler<AddUserRequest, AddUserResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public AddUserHandler(IUserRepository userRepository,
             IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<AddUserResponse> Handle(AddUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);
            await _userRepository.AddAsync(user);
            return _mapper.Map<AddUserResponse>(user);
        }
    }
}
