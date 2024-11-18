using CleanArchitectureDotNet9.Application.Repository.ICommon;
using CleanArchitectureDotNet9.Domain.Entities;

namespace CleanArchitectureDotNet9.Application.Repository.UserRepository
{
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}
