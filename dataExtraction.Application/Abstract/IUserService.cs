using dataExtraction.Domain.entities;

namespace dataExtraction.Application.Abstract
{
    public interface IUserService
    {
        abstract List<User> GetAllUsers();
    }
}
