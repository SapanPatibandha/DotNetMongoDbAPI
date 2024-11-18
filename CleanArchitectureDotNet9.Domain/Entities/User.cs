using CleanArchitectureDotNet9.Domain.Common;

namespace CleanArchitectureDotNet9.Domain.Entities
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
