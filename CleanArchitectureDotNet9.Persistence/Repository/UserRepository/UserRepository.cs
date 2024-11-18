using CleanArchitectureDotNet9.Application.Repository.UserRepository;
using CleanArchitectureDotNet9.Domain.Entities;
using CleanArchitectureDotNet9.Persistence.Repository.Common;
using MongoDB.Driver;

namespace CleanArchitectureDotNet9.Persistence.Repository.UserRepository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IMongoDatabase database)
            : base(database, "Users") { }
    }
}
