using System.Threading.Tasks;
using Model;

namespace SLInterface
{
    public interface IUserService
    {
        Task<int> AddNewUser(User user);
        Task UpdateUser(User user);
    }
}